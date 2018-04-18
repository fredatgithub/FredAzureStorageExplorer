using FredAzureStorageExplorer.Properties;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredAzureStorageExplorer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWindowValues();
            Application.Exit();
        }

        private void GetWindowValues()
        {
            Width = Settings.Default.WindowWidth;
            Height = Settings.Default.WindowHeight;
            Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
            Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
            tabControlMain.SelectedIndex = Settings.Default.tabControlMainSelectedIndex;
            textBoxBlobUploadFilePath.Text = Settings.Default.textBoxBlobUploadFilePath;
        }

        private void SaveWindowValues()
        {
            Settings.Default.WindowHeight = Height;
            Settings.Default.WindowWidth = Width;
            Settings.Default.WindowLeft = Left;
            Settings.Default.WindowTop = Top;
            Settings.Default.tabControlMainSelectedIndex = tabControlMain.SelectedIndex;
            Settings.Default.textBoxBlobUploadFilePath = textBoxBlobUploadFilePath.Text;
            Settings.Default.Save();
        }

        private void DisplayTitle()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $@" V{fvi.FileMajorPart}.{fvi.FileMinorPart}.{fvi.FileBuildPart}.{fvi.FilePrivatePart}";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayTitle();
            GetWindowValues();
            // load any settings
            textBoxAccountName.Text = Settings.Default.accountName;
            textBoxAccountKey.Text = Settings.Default.accountKey;
        }

        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            listViewTable.Items.Clear();
            listViewTable.Columns.Clear();
            listViewTable.Columns.Add("Select", 45, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Partition Key", 100, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Row Key", 60, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Timestamp", 170, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Enable", 50, HorizontalAlignment.Left);
            listViewTable.Columns.Add("HCode", 50, HorizontalAlignment.Left);
            listViewTable.Columns.Add("HCode", 70, HorizontalAlignment.Left);
            listViewTable.Columns.Add("MachineName", 130, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Mode", 40, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Status", 45, HorizontalAlignment.Left);
            listViewTable.Columns.Add("BlobUrl", 130, HorizontalAlignment.Left);
            listViewTable.Columns.Add("TargetDate", 130, HorizontalAlignment.Left);
            listViewTable.Columns.Add("Comments", 100, HorizontalAlignment.Left);

            listViewTable.View = View.Details;
            listViewTable.LabelEdit = false;
            listViewTable.AllowColumnReorder = true;
            listViewTable.CheckBoxes = true;
            listViewTable.FullRowSelect = true;
            listViewTable.GridLines = true;
            listViewTable.Sorting = SortOrder.None;
            
            foreach (UpdateEntity entity in GetEntitiesFromTable())
            {
                ListViewItem newLine = new ListViewItem { Checked = false };

                newLine.SubItems.Add(entity.PartitionKey);
                newLine.SubItems.Add(entity.RowKey);
                newLine.SubItems.Add(entity.Timestamp.ToString());
                newLine.SubItems.Add(entity.Enabled.ToString());
                newLine.SubItems.Add(entity.HId);
                newLine.SubItems.Add(entity.HCode);
                newLine.SubItems.Add(entity.MachineName);
                newLine.SubItems.Add(entity.Mode.ToString());
                newLine.SubItems.Add(entity.Status.ToString());
                newLine.SubItems.Add(entity.BlobUrl);
                newLine.SubItems.Add(entity.TargetDate.ToString());
                newLine.SubItems.Add(entity.Comments);

                listViewTable.Items.Add(newLine);
            }
        }

        private List<UpdateEntity> GetEntitiesFromTable()
        {
            CloudTable table = GetTable();
            table.CreateIfNotExists();

            if (table == null)
            {
                throw new Exception("Cannot retrieve table");
            }

            var query = new TableQuery<UpdateEntity>();
            var entities = table.ExecuteQuery(query).ToList();
            return entities;
        }

        private CloudTable GetTable()
        {
            try
            {
                string accountName = textBoxAccountName.Text;
                string accountKey = textBoxAccountKey.Text;
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse($"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey};EndpointSuffix=core.windows.net");
                var tableClient = storageAccount.CreateCloudTableClient();
                CloudTable table = tableClient.GetTableReference("Update");
                table.CreateIfNotExists();
                return table;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        private void buttonTableInsert_Click(object sender, EventArgs e)
        {
            if (textBoxTablePartitionKey.Text.Trim() == string.Empty || textBoxTableRowKey.Text.Trim() == string.Empty)
            {
                MessageBox.Show(@"Partition key or Row key cannot be empty", @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // create a new Entity
            UpdateEntity newLine = CreateEntity(textBoxTableBlobUrl.Text, textBoxTableComments.Text,
                textBoxTableEnabled.Text, textBoxTableHCode.Text, textBoxTableHCode.Text,
                textBoxTableMachineName.Text, textBoxTableMode.Text, textBoxTableStatus.Text,
                textBoxTableTargetDate.Text, textBoxTablePartitionKey.Text, textBoxTableRowKey.Text, true);

            try
            {
                //insert into Azure table
                InsertIntoTable(newLine);
                MessageBox.Show(@"The line has been inserted into the Azure Table", @"OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"The line has not been inserted into the Azure Table. Error: {exception.Message}", @"KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the table
            buttonLoadTable_Click(sender, e);
        }

        private static UpdateEntity CreateEntity(string blobUrl, string comment, string enableEntity, string HCode, string HId, string machineName, string modeEntity, string statusEntity, string targetDate, string partitionKey, string rowKey, bool insertNewLine = true )
        {
            UpdateEntity newLine = new UpdateEntity();
            newLine.BlobUrl = blobUrl;
            newLine.Comments = comment;
            bool enabled = false;
            if (!bool.TryParse(enableEntity, out enabled))
            {
                enabled = false;
            }

            newLine.Enabled = enabled;
            newLine.HCode = HCode;
            newLine.HId = HId;
            newLine.MachineName = machineName.Replace(' ', new char());
            int mode = 0;
            if (!int.TryParse(modeEntity, out mode))
            {
                mode = 0;
            }

            newLine.Mode = mode;

            int status = 0;
            if (!int.TryParse(statusEntity, out status))
            {
                status = 0;
            }

            newLine.Status = status;
            DateTime targetDateTime;
            if (!DateTime.TryParse(targetDate, out targetDateTime))
            {
                targetDateTime = DateTime.Now;
            }

            newLine.TargetDate = targetDateTime;
            newLine.PartitionKey = partitionKey;
            newLine.RowKey = rowKey;
            newLine.Timestamp = DateTime.Now;

            // check if line already exists and if so ask for confirmation to replace and add *
            newLine.ETag = insertNewLine ? string.Empty : "*";

            return newLine;
        }

        private void listViewTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update textboxes according to the selected line
            if (listViewTable.Items.Count == 0)
            {
                MessageBox.Show(@"The table is empty, you should load the table before updating any item", @"Table empty", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                ListViewItem selectedItem = listViewTable.SelectedItems[0];
                textBoxTablePartitionKey.Text = selectedItem.SubItems[1].Text;
                textBoxTableRowKey.Text = selectedItem.SubItems[2].Text;
                textBoxTableTimeStamp.Text = selectedItem.SubItems[3].Text;
                textBoxTableEnabled.Text = selectedItem.SubItems[4].Text;
                textBoxTableHCode.Text = selectedItem.SubItems[5].Text;
                textBoxTableHCode.Text = selectedItem.SubItems[6].Text;
                textBoxTableMachineName.Text = selectedItem.SubItems[7].Text;
                textBoxTableMode.Text = selectedItem.SubItems[8].Text;
                textBoxTableStatus.Text = selectedItem.SubItems[9].Text;
                textBoxTableBlobUrl.Text = selectedItem.SubItems[10].Text;
                textBoxTableTargetDate.Text = selectedItem.SubItems[11].Text;
                textBoxTableComments.Text = selectedItem.SubItems[12].Text;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public TableResult UpdateTable(ITableEntity entity)
        {
            try
            {
                CloudTable table = GetTable();
                TableOperation replaceOperation = TableOperation.Replace(entity);
                return table.Execute(replaceOperation);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Failed to update the Table - {exception.Message}");
            }

            return null;
        }

        public TableResult InsertIntoTable(ITableEntity entity)
        {
            try
            {
                CloudTable table = GetTable();
                TableOperation insertOperation = TableOperation.Insert(entity);
                return table.Execute(insertOperation);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Failed to insert the Table - {exception.Message}");
            }

            return null;
        }

        private void buttonTableUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxTablePartitionKey.Text.Trim() == string.Empty || textBoxTableRowKey.Text.Trim() == string.Empty)
            {
                MessageBox.Show(@"Partition key or Row key cannot be empty", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // update table
            UpdateEntity newLine = CreateEntity(textBoxTableBlobUrl.Text, textBoxTableComments.Text,
                textBoxTableEnabled.Text, textBoxTableHCode.Text, textBoxTableHCode.Text,
                textBoxTableMachineName.Text, textBoxTableMode.Text, textBoxTableStatus.Text,
                textBoxTableTargetDate.Text, textBoxTablePartitionKey.Text, textBoxTableRowKey.Text, false);

            try
            {
                //insert into Azure table
                UpdateTable(newLine);
                MessageBox.Show(@"The line has been updated into the Azure Table", @"OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"The line has not been updated into the Azure Table. Error: {exception.Message}", @"KO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the table
            buttonLoadTable_Click(sender, e);
        }

        private void buttonTableClear_Click(object sender, EventArgs e)
        {
            listViewTable.Items.Clear();
        }

        private void buttonBlobUpload_Click(object sender, EventArgs e)
        {
            if (textBoxBlobUploadFilePath.Text.Trim() == string.Empty)
            {
                MessageBox.Show(@"The path cannot be empty", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(textBoxBlobUploadFilePath.Text.Trim()))
            {
                MessageBox.Show(@"The file cannot be found", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxBlobVersionFolderName.Text.Trim() == string.Empty)
            {
                MessageBox.Show(@"The version folder name cannot be empty, the file will be uploaded into a folder named with a version", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                //TODO add code to upload something like
                //UploadfileToBlobAzure(textBoxBlobUploadFilePath.Text);
                //MessageBox.Show($@"The file {textBoxBlobUploadFilePath.Text} has been uploaded into {textBoxAccountName.Text}", @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($@"The file {textBoxBlobUploadFilePath.Text} has not been uploaded into {textBoxAccountName.Text}. The error is {exception.Message}", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UploadfileToBlobAzure(string localfilePath, string blobfilePath = "package")
        {
            string accountName = textBoxAccountName.Text.ToLower(); // Azure naming convention in lower case
            string accountKey = textBoxAccountKey.Text;
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse($"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey};EndpointSuffix=core.windows.net");
            var blobStorageUri = storageAccount.BlobStorageUri;
            // Create the CloudBlobClient that represents the Blob storage endpoint for the storage account.
            CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer cloudBlobContainer = cloudBlobClient.GetContainerReference("update");
            await cloudBlobContainer.CreateAsync();

            // Set the permissions so the blobs are public. 
            BlobContainerPermissions permissions = new BlobContainerPermissions
            {
                PublicAccess = BlobContainerPublicAccessType.Blob
            };

            await cloudBlobContainer.SetPermissionsAsync(permissions);
            
            // Get a reference to the blob address, then upload the file to the blob.
            CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(blobfilePath);
            await cloudBlockBlob.UploadFromFileAsync(localfilePath);
        }

        private static async Task UploadFileToBlob(string blobFilePath, string localFilePath)
        {
            var writeSas = FileStorageSasHelper.GetWriteSharedAccessSignature(blobFilePath);
            IBlobClient blobClient = new BlobClient();
            await blobClient.UploadFromFileAsync(writeSas.ToString(), localFilePath, null, true);
            try
            {
                var blob = new CloudBlockBlob(new Uri(blobFilePath));
                if (File.Exists(localFilePath))
                {
                    var msWrite = new MemoryStream(File.ReadAllBytes(localFilePath)) { Position = 0 };
                    using (msWrite)
                    {
                        await blob.UploadFromStreamAsync(msWrite);
                    }
                }

                MessageBox.Show(@"file uploaded correctly");
            }
            catch (StorageException exception)
            {
                MessageBox.Show($@"file not uploaded correctly, the exception is {exception.Message}");
                throw;
            }
        }

        private void buttonBlobUploadGetFile_Click(object sender, EventArgs e)
        {
            textBoxBlobUploadFilePath.Text = ChooseOneFile("MSI files (*.msi)|*.msi|All files (*.*)|*.*");
        }

        private static string ChooseOneFile(string filter = "All files (*.*)|*.*", bool checkIfFileExists = true, string initialDirectory = "")
        {
            string result = string.Empty;
            FileDialog fd = new OpenFileDialog();
            fd.Filter = filter;
            fd.CheckFileExists = checkIfFileExists;
            if (initialDirectory == string.Empty)
            {
                initialDirectory = $"{Environment.GetEnvironmentVariable("systemdrive")}\\";
            }

            fd.InitialDirectory = initialDirectory;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                result = fd.FileName;
            }

            return result;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveWindowValues();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control focusedControl = FindFocusedControl(new List<Control>
            {
                // Config tab
                textBoxAccountName,
                textBoxTableRowKey,
                // Blob upload tab
                textBoxBlobUploadFilePath,
                // Table tab
                textBoxTablePartitionKey,
                textBoxTableRowKey,
                textBoxTableTimeStamp,
                textBoxTableEnabled,
                textBoxTableHCode,
                textBoxTableHId,
                textBoxTableMachineName,
                textBoxTableMode,
                textBoxTableStatus,
                textBoxTableBlobUrl,
                textBoxTableTargetDate,
                textBoxTableComments
            }); 
            var tb = focusedControl as TextBox;
            if (tb != null)
            {
                CutToClipboard(tb);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control focusedControl = FindFocusedControl(new List<Control>
            {
                // Config tab
                textBoxAccountName,
                textBoxTableRowKey,
                // Blob upload tab
                textBoxBlobUploadFilePath,
                // Table tab
                textBoxTablePartitionKey,
                textBoxTableRowKey,
                textBoxTableTimeStamp,
                textBoxTableEnabled,
                textBoxTableHCode,
                textBoxTableHCode,
                textBoxTableMachineName,
                textBoxTableMode,
                textBoxTableStatus,
                textBoxTableBlobUrl,
                textBoxTableTargetDate,
                textBoxTableComments
            }); 
            var tb = focusedControl as TextBox;
            if (tb != null)
            {
                CopyToClipboard(tb);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control focusedControl = FindFocusedControl(new List<Control>
            {
                // Config tab
                textBoxAccountName,
                textBoxTableRowKey,
                // Blob upload tab
                textBoxBlobUploadFilePath,
                // Table tab
                textBoxTablePartitionKey,
                textBoxTableRowKey,
                textBoxTableTimeStamp,
                textBoxTableEnabled,
                textBoxTableHCode,
                textBoxTableHCode,
                textBoxTableMachineName,
                textBoxTableMode,
                textBoxTableStatus,
                textBoxTableBlobUrl,
                textBoxTableTargetDate,
                textBoxTableComments
            });
            var tb = focusedControl as TextBox;
            if (tb != null)
            {
                PasteFromClipboard(tb);
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control focusedControl = FindFocusedControl(new List<Control>
            {
                // Config tab
                textBoxAccountName,
                textBoxTableRowKey,
                // Blob upload tab
                textBoxBlobUploadFilePath,
                // Table tab
                textBoxTablePartitionKey,
                textBoxTableRowKey,
                textBoxTableTimeStamp,
                textBoxTableEnabled,
                textBoxTableHCode,
                textBoxTableHCode,
                textBoxTableMachineName,
                textBoxTableMode,
                textBoxTableStatus,
                textBoxTableBlobUrl,
                textBoxTableTargetDate,
                textBoxTableComments
            }); 
            TextBox control = focusedControl as TextBox;
            control?.SelectAll();
        }

        private void CutToClipboard(TextBoxBase tb, string errorMessage = "nothing")
        {
            if (tb != ActiveControl) return;
            if (tb.Text == string.Empty)
            {
                DisplayMessage("There Is " + errorMessage + " " + "To Cut ", errorMessage, MessageBoxButtons.OK);
                return;
            }

            if (tb.SelectedText == string.Empty)
            {
                DisplayMessage("No Text Has Been Selected", errorMessage, MessageBoxButtons.OK);
                return;
            }

            Clipboard.SetText(tb.SelectedText);
            tb.SelectedText = string.Empty;
        }

        private void CopyToClipboard(TextBoxBase tb, string message = "nothing")
        {
            if (tb != ActiveControl) return;
            if (tb.Text == string.Empty)
            {
                DisplayMessage($"There Is Nothing To Copy", message, MessageBoxButtons.OK);
                return;
            }

            if (tb.SelectedText == string.Empty)
            {
                DisplayMessage("No Text Has Been Selected", message, MessageBoxButtons.OK);
                return;
            }

            Clipboard.SetText(tb.SelectedText);
        }

        private void PasteFromClipboard(TextBoxBase tb)
        {
            if (tb != ActiveControl) return;
            var selectionIndex = tb.SelectionStart;
            tb.SelectedText = Clipboard.GetText();
            tb.SelectionStart = selectionIndex + Clipboard.GetText().Length;
        }

        private void DisplayMessage(string message, string title, MessageBoxButtons buttons)
        {
            MessageBox.Show(this, message, title, buttons);
        }

        private static Control FindFocusedControl(Control container)
        {
            foreach (Control childControl in container.Controls.Cast<Control>().Where(childControl => childControl.Focused))
            {
                return childControl;
            }

            return (from Control childControl in container.Controls
                select FindFocusedControl(childControl)).FirstOrDefault(maybeFocusedControl => maybeFocusedControl != null);
        }

        private static Control FindFocusedControl(List<Control> container)
        {
            return container.FirstOrDefault(control => control.Focused);
        }

        private static Control FindFocusedControl(params Control[] container)
        {
            return container.FirstOrDefault(control => control.Focused);
        }

        private static Control FindFocusedControl(IEnumerable<Control> container)
        {
            return container.FirstOrDefault(control => control.Focused);
        }

        private static string PeekDirectory()
        {
            string result = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                result = fbd.SelectedPath;
            }

            return result;
        }

        private string PeekFile()
        {
            string result = string.Empty;
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                result = fd.SafeFileName;
            }

            return result;
        }

        private static void SetButtonEnabled(Button button, params Control[] controls)
        {
            bool result = true;
            foreach (Control ctrl in controls)
            {
                if (ctrl.GetType() == typeof(TextBox))
                {
                    if (((TextBox)ctrl).Text == string.Empty)
                    {
                        result = false;
                        break;
                    }
                }

                if (ctrl.GetType() == typeof(ListView))
                {
                    if (((ListView)ctrl).Items.Count == 0)
                    {
                        result = false;
                        break;
                    }
                }

                if (ctrl.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)ctrl).SelectedIndex == -1)
                    {
                        result = false;
                        break;
                    }
                }
            }

            button.Enabled = result;
        }

        private void textBoxBlobUploadFilePath_TextChanged(object sender, EventArgs e)
        {
            buttonBlobUpload.Enabled = File.Exists(textBoxBlobUploadFilePath.Text.Trim());
        }
    }
}