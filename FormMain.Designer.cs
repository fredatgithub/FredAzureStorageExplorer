namespace FredAzureStorageExplorer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSas = new System.Windows.Forms.TabPage();
            this.textBoxAccountKey = new System.Windows.Forms.TextBox();
            this.labelAccountKey = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.tabPageTable = new System.Windows.Forms.TabPage();
            this.buttonTableClear = new System.Windows.Forms.Button();
            this.buttonTableUpdate = new System.Windows.Forms.Button();
            this.textBoxTableComments = new System.Windows.Forms.TextBox();
            this.labelTableComments = new System.Windows.Forms.Label();
            this.textBoxTableTargetDate = new System.Windows.Forms.TextBox();
            this.labelTableTargetDate = new System.Windows.Forms.Label();
            this.textBoxTableBlobUrl = new System.Windows.Forms.TextBox();
            this.labelBlobUrl = new System.Windows.Forms.Label();
            this.textBoxTableStatus = new System.Windows.Forms.TextBox();
            this.labelTableStatus = new System.Windows.Forms.Label();
            this.textBoxTableMode = new System.Windows.Forms.TextBox();
            this.labelTableMode = new System.Windows.Forms.Label();
            this.textBoxTableMachineName = new System.Windows.Forms.TextBox();
            this.labelTableMachineName = new System.Windows.Forms.Label();
            this.textBoxTableHCode = new System.Windows.Forms.TextBox();
            this.labelTableHId = new System.Windows.Forms.Label();
            this.textBoxTableHId = new System.Windows.Forms.TextBox();
            this.labelTableHCode = new System.Windows.Forms.Label();
            this.textBoxTableEnabled = new System.Windows.Forms.TextBox();
            this.labelTableEnabled = new System.Windows.Forms.Label();
            this.textBoxTableTimeStamp = new System.Windows.Forms.TextBox();
            this.labelTableTimeStamp = new System.Windows.Forms.Label();
            this.textBoxTableRowKey = new System.Windows.Forms.TextBox();
            this.labelTableRowKey = new System.Windows.Forms.Label();
            this.buttonTableInsert = new System.Windows.Forms.Button();
            this.textBoxTablePartitionKey = new System.Windows.Forms.TextBox();
            this.labelTablePartitionKey = new System.Windows.Forms.Label();
            this.buttonLoadTable = new System.Windows.Forms.Button();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.tabPageBlob = new System.Windows.Forms.TabPage();
            this.textBoxBlobVersionFolderName = new System.Windows.Forms.TextBox();
            this.labelBlobVersionFolderName = new System.Windows.Forms.Label();
            this.buttonBlobUploadGetFile = new System.Windows.Forms.Button();
            this.textBoxBlobUploadFilePath = new System.Windows.Forms.TextBox();
            this.buttonBlobUpload = new System.Windows.Forms.Button();
            this.labelBlobUploadPath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabPageSas.SuspendLayout();
            this.tabPageTable.SuspendLayout();
            this.tabPageBlob.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSas);
            this.tabControlMain.Controls.Add(this.tabPageTable);
            this.tabControlMain.Controls.Add(this.tabPageBlob);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 33);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1402, 778);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageSas
            // 
            this.tabPageSas.Controls.Add(this.textBoxAccountKey);
            this.tabPageSas.Controls.Add(this.labelAccountKey);
            this.tabPageSas.Controls.Add(this.textBoxAccountName);
            this.tabPageSas.Controls.Add(this.labelAccountName);
            this.tabPageSas.Location = new System.Drawing.Point(4, 29);
            this.tabPageSas.Name = "tabPageSas";
            this.tabPageSas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSas.Size = new System.Drawing.Size(1394, 745);
            this.tabPageSas.TabIndex = 0;
            this.tabPageSas.Text = "Configuration";
            this.tabPageSas.UseVisualStyleBackColor = true;
            // 
            // textBoxAccountKey
            // 
            this.textBoxAccountKey.Location = new System.Drawing.Point(219, 110);
            this.textBoxAccountKey.Name = "textBoxAccountKey";
            this.textBoxAccountKey.Size = new System.Drawing.Size(852, 26);
            this.textBoxAccountKey.TabIndex = 3;
            this.textBoxAccountKey.Text = "your account key";
            // 
            // labelAccountKey
            // 
            this.labelAccountKey.AutoSize = true;
            this.labelAccountKey.Location = new System.Drawing.Point(63, 110);
            this.labelAccountKey.Name = "labelAccountKey";
            this.labelAccountKey.Size = new System.Drawing.Size(102, 20);
            this.labelAccountKey.TabIndex = 2;
            this.labelAccountKey.Text = "Account Key:";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(219, 78);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(852, 26);
            this.textBoxAccountName.TabIndex = 1;
            this.textBoxAccountName.Text = "your account name";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(63, 78);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(118, 20);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "Account Name:";
            // 
            // tabPageTable
            // 
            this.tabPageTable.Controls.Add(this.buttonTableClear);
            this.tabPageTable.Controls.Add(this.buttonTableUpdate);
            this.tabPageTable.Controls.Add(this.textBoxTableComments);
            this.tabPageTable.Controls.Add(this.labelTableComments);
            this.tabPageTable.Controls.Add(this.textBoxTableTargetDate);
            this.tabPageTable.Controls.Add(this.labelTableTargetDate);
            this.tabPageTable.Controls.Add(this.textBoxTableBlobUrl);
            this.tabPageTable.Controls.Add(this.labelBlobUrl);
            this.tabPageTable.Controls.Add(this.textBoxTableStatus);
            this.tabPageTable.Controls.Add(this.labelTableStatus);
            this.tabPageTable.Controls.Add(this.textBoxTableMode);
            this.tabPageTable.Controls.Add(this.labelTableMode);
            this.tabPageTable.Controls.Add(this.textBoxTableMachineName);
            this.tabPageTable.Controls.Add(this.labelTableMachineName);
            this.tabPageTable.Controls.Add(this.textBoxTableHCode);
            this.tabPageTable.Controls.Add(this.labelTableHId);
            this.tabPageTable.Controls.Add(this.textBoxTableHId);
            this.tabPageTable.Controls.Add(this.labelTableHCode);
            this.tabPageTable.Controls.Add(this.textBoxTableEnabled);
            this.tabPageTable.Controls.Add(this.labelTableEnabled);
            this.tabPageTable.Controls.Add(this.textBoxTableTimeStamp);
            this.tabPageTable.Controls.Add(this.labelTableTimeStamp);
            this.tabPageTable.Controls.Add(this.textBoxTableRowKey);
            this.tabPageTable.Controls.Add(this.labelTableRowKey);
            this.tabPageTable.Controls.Add(this.buttonTableInsert);
            this.tabPageTable.Controls.Add(this.textBoxTablePartitionKey);
            this.tabPageTable.Controls.Add(this.labelTablePartitionKey);
            this.tabPageTable.Controls.Add(this.buttonLoadTable);
            this.tabPageTable.Controls.Add(this.listViewTable);
            this.tabPageTable.Location = new System.Drawing.Point(4, 29);
            this.tabPageTable.Name = "tabPageTable";
            this.tabPageTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTable.Size = new System.Drawing.Size(1394, 745);
            this.tabPageTable.TabIndex = 1;
            this.tabPageTable.Text = "Table";
            this.tabPageTable.UseVisualStyleBackColor = true;
            // 
            // buttonTableClear
            // 
            this.buttonTableClear.Location = new System.Drawing.Point(147, 53);
            this.buttonTableClear.Name = "buttonTableClear";
            this.buttonTableClear.Size = new System.Drawing.Size(92, 30);
            this.buttonTableClear.TabIndex = 28;
            this.buttonTableClear.Text = "Clear";
            this.buttonTableClear.UseVisualStyleBackColor = true;
            this.buttonTableClear.Click += new System.EventHandler(this.ButtonTableClearClick);
            // 
            // buttonTableUpdate
            // 
            this.buttonTableUpdate.Location = new System.Drawing.Point(147, 321);
            this.buttonTableUpdate.Name = "buttonTableUpdate";
            this.buttonTableUpdate.Size = new System.Drawing.Size(92, 30);
            this.buttonTableUpdate.TabIndex = 27;
            this.buttonTableUpdate.Text = "Update";
            this.buttonTableUpdate.UseVisualStyleBackColor = true;
            this.buttonTableUpdate.Click += new System.EventHandler(this.ButtonTableUpdateClick);
            // 
            // textBoxTableComments
            // 
            this.textBoxTableComments.Location = new System.Drawing.Point(1048, 258);
            this.textBoxTableComments.Name = "textBoxTableComments";
            this.textBoxTableComments.Size = new System.Drawing.Size(271, 26);
            this.textBoxTableComments.TabIndex = 26;
            this.textBoxTableComments.Text = "test";
            // 
            // labelTableComments
            // 
            this.labelTableComments.AutoSize = true;
            this.labelTableComments.Location = new System.Drawing.Point(1044, 214);
            this.labelTableComments.Name = "labelTableComments";
            this.labelTableComments.Size = new System.Drawing.Size(86, 20);
            this.labelTableComments.TabIndex = 25;
            this.labelTableComments.Text = "Comments";
            // 
            // textBoxTableTargetDate
            // 
            this.textBoxTableTargetDate.Location = new System.Drawing.Point(861, 258);
            this.textBoxTableTargetDate.Name = "textBoxTableTargetDate";
            this.textBoxTableTargetDate.Size = new System.Drawing.Size(181, 26);
            this.textBoxTableTargetDate.TabIndex = 24;
            this.textBoxTableTargetDate.Text = "2018-03-21T16:09:00";
            // 
            // labelTableTargetDate
            // 
            this.labelTableTargetDate.AutoSize = true;
            this.labelTableTargetDate.Location = new System.Drawing.Point(861, 214);
            this.labelTableTargetDate.Name = "labelTableTargetDate";
            this.labelTableTargetDate.Size = new System.Drawing.Size(91, 20);
            this.labelTableTargetDate.TabIndex = 23;
            this.labelTableTargetDate.Text = "Target date";
            // 
            // textBoxTableBlobUrl
            // 
            this.textBoxTableBlobUrl.Location = new System.Drawing.Point(34, 258);
            this.textBoxTableBlobUrl.Name = "textBoxTableBlobUrl";
            this.textBoxTableBlobUrl.Size = new System.Drawing.Size(804, 26);
            this.textBoxTableBlobUrl.TabIndex = 22;
            this.textBoxTableBlobUrl.Text = "https://storagename.blob.core.windows.net/update/Setup.msi";
            // 
            // labelBlobUrl
            // 
            this.labelBlobUrl.AutoSize = true;
            this.labelBlobUrl.Location = new System.Drawing.Point(34, 214);
            this.labelBlobUrl.Name = "labelBlobUrl";
            this.labelBlobUrl.Size = new System.Drawing.Size(78, 20);
            this.labelBlobUrl.TabIndex = 21;
            this.labelBlobUrl.Text = "Blob URL";
            // 
            // textBoxTableStatus
            // 
            this.textBoxTableStatus.Location = new System.Drawing.Point(1276, 169);
            this.textBoxTableStatus.Name = "textBoxTableStatus";
            this.textBoxTableStatus.Size = new System.Drawing.Size(43, 26);
            this.textBoxTableStatus.TabIndex = 20;
            this.textBoxTableStatus.Text = "0";
            // 
            // labelTableStatus
            // 
            this.labelTableStatus.AutoSize = true;
            this.labelTableStatus.Location = new System.Drawing.Point(1276, 125);
            this.labelTableStatus.Name = "labelTableStatus";
            this.labelTableStatus.Size = new System.Drawing.Size(56, 20);
            this.labelTableStatus.TabIndex = 19;
            this.labelTableStatus.Text = "Status";
            // 
            // textBoxTableMode
            // 
            this.textBoxTableMode.Location = new System.Drawing.Point(1223, 169);
            this.textBoxTableMode.Name = "textBoxTableMode";
            this.textBoxTableMode.Size = new System.Drawing.Size(36, 26);
            this.textBoxTableMode.TabIndex = 18;
            this.textBoxTableMode.Text = "0";
            // 
            // labelTableMode
            // 
            this.labelTableMode.AutoSize = true;
            this.labelTableMode.Location = new System.Drawing.Point(1223, 125);
            this.labelTableMode.Name = "labelTableMode";
            this.labelTableMode.Size = new System.Drawing.Size(49, 20);
            this.labelTableMode.TabIndex = 17;
            this.labelTableMode.Text = "Mode";
            // 
            // textBoxTableMachineName
            // 
            this.textBoxTableMachineName.Location = new System.Drawing.Point(1063, 169);
            this.textBoxTableMachineName.Name = "textBoxTableMachineName";
            this.textBoxTableMachineName.Size = new System.Drawing.Size(149, 26);
            this.textBoxTableMachineName.TabIndex = 16;
            this.textBoxTableMachineName.Text = "MachineName1234";
            // 
            // labelTableMachineName
            // 
            this.labelTableMachineName.AutoSize = true;
            this.labelTableMachineName.Location = new System.Drawing.Point(1063, 125);
            this.labelTableMachineName.Name = "labelTableMachineName";
            this.labelTableMachineName.Size = new System.Drawing.Size(115, 20);
            this.labelTableMachineName.TabIndex = 15;
            this.labelTableMachineName.Text = "Machine Name";
            // 
            // textBoxTableHCode
            // 
            this.textBoxTableHCode.Location = new System.Drawing.Point(982, 169);
            this.textBoxTableHCode.Name = "textBoxTableHCode";
            this.textBoxTableHCode.Size = new System.Drawing.Size(68, 26);
            this.textBoxTableHCode.TabIndex = 14;
            this.textBoxTableHCode.Text = "1400";
            // 
            // labelTableHId
            // 
            this.labelTableHId.AutoSize = true;
            this.labelTableHId.Location = new System.Drawing.Point(982, 125);
            this.labelTableHId.Name = "labelTableHId";
            this.labelTableHId.Size = new System.Drawing.Size(26, 20);
            this.labelTableHId.TabIndex = 13;
            this.labelTableHId.Text = "ID";
            // 
            // labelTableHCode
            // 
            this.labelTableHCode.AutoSize = true;
            this.labelTableHCode.Location = new System.Drawing.Point(881, 125);
            this.labelTableHCode.Name = "labelTableHCode";
            this.labelTableHCode.Size = new System.Drawing.Size(47, 20);
            this.labelTableHCode.TabIndex = 11;
            this.labelTableHCode.Text = "Code";
            // 
            // textBoxTableEnabled
            // 
            this.textBoxTableEnabled.Location = new System.Drawing.Point(800, 169);
            this.textBoxTableEnabled.Name = "textBoxTableEnabled";
            this.textBoxTableEnabled.Size = new System.Drawing.Size(68, 26);
            this.textBoxTableEnabled.TabIndex = 10;
            this.textBoxTableEnabled.Text = "true";
            // 
            // labelTableEnabled
            // 
            this.labelTableEnabled.AutoSize = true;
            this.labelTableEnabled.Location = new System.Drawing.Point(800, 125);
            this.labelTableEnabled.Name = "labelTableEnabled";
            this.labelTableEnabled.Size = new System.Drawing.Size(68, 20);
            this.labelTableEnabled.TabIndex = 9;
            this.labelTableEnabled.Text = "Enabled";
            // 
            // textBoxTableTimeStamp
            // 
            this.textBoxTableTimeStamp.Location = new System.Drawing.Point(632, 169);
            this.textBoxTableTimeStamp.Name = "textBoxTableTimeStamp";
            this.textBoxTableTimeStamp.Size = new System.Drawing.Size(162, 26);
            this.textBoxTableTimeStamp.TabIndex = 8;
            this.textBoxTableTimeStamp.Text = "2018-03-16T15:38:41";
            // 
            // labelTableTimeStamp
            // 
            this.labelTableTimeStamp.AutoSize = true;
            this.labelTableTimeStamp.Location = new System.Drawing.Point(632, 125);
            this.labelTableTimeStamp.Name = "labelTableTimeStamp";
            this.labelTableTimeStamp.Size = new System.Drawing.Size(91, 20);
            this.labelTableTimeStamp.TabIndex = 7;
            this.labelTableTimeStamp.Text = "Time stamp";
            // 
            // textBoxTableRowKey
            // 
            this.textBoxTableRowKey.Location = new System.Drawing.Point(464, 169);
            this.textBoxTableRowKey.Name = "textBoxTableRowKey";
            this.textBoxTableRowKey.Size = new System.Drawing.Size(162, 26);
            this.textBoxTableRowKey.TabIndex = 6;
            this.textBoxTableRowKey.Text = "1.2.7.0";
            // 
            // labelTableRowKey
            // 
            this.labelTableRowKey.AutoSize = true;
            this.labelTableRowKey.Location = new System.Drawing.Point(464, 125);
            this.labelTableRowKey.Name = "labelTableRowKey";
            this.labelTableRowKey.Size = new System.Drawing.Size(71, 20);
            this.labelTableRowKey.TabIndex = 5;
            this.labelTableRowKey.Text = "Row Key";
            // 
            // buttonTableInsert
            // 
            this.buttonTableInsert.Location = new System.Drawing.Point(34, 321);
            this.buttonTableInsert.Name = "buttonTableInsert";
            this.buttonTableInsert.Size = new System.Drawing.Size(92, 30);
            this.buttonTableInsert.TabIndex = 4;
            this.buttonTableInsert.Text = "Insert";
            this.buttonTableInsert.UseVisualStyleBackColor = true;
            this.buttonTableInsert.Click += new System.EventHandler(this.ButtonTableInsertClick);
            // 
            // textBoxTablePartitionKey
            // 
            this.textBoxTablePartitionKey.Location = new System.Drawing.Point(34, 169);
            this.textBoxTablePartitionKey.Name = "textBoxTablePartitionKey";
            this.textBoxTablePartitionKey.Size = new System.Drawing.Size(424, 26);
            this.textBoxTablePartitionKey.TabIndex = 3;
            this.textBoxTablePartitionKey.Text = "your partition key";
            // 
            // labelTablePartitionKey
            // 
            this.labelTablePartitionKey.AutoSize = true;
            this.labelTablePartitionKey.Location = new System.Drawing.Point(34, 125);
            this.labelTablePartitionKey.Name = "labelTablePartitionKey";
            this.labelTablePartitionKey.Size = new System.Drawing.Size(97, 20);
            this.labelTablePartitionKey.TabIndex = 2;
            this.labelTablePartitionKey.Text = "Partition Key";
            // 
            // buttonLoadTable
            // 
            this.buttonLoadTable.Location = new System.Drawing.Point(34, 53);
            this.buttonLoadTable.Name = "buttonLoadTable";
            this.buttonLoadTable.Size = new System.Drawing.Size(92, 30);
            this.buttonLoadTable.TabIndex = 1;
            this.buttonLoadTable.Text = "Load";
            this.buttonLoadTable.UseVisualStyleBackColor = true;
            this.buttonLoadTable.Click += new System.EventHandler(this.ButtonLoadTableClick);
            // 
            // listViewTable
            // 
            this.listViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTable.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewTable.Location = new System.Drawing.Point(19, 388);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(1353, 326);
            this.listViewTable.TabIndex = 0;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.SelectedIndexChanged += new System.EventHandler(this.ListViewTableSelectedIndexChanged);
            // 
            // tabPageBlob
            // 
            this.tabPageBlob.Controls.Add(this.textBoxBlobVersionFolderName);
            this.tabPageBlob.Controls.Add(this.labelBlobVersionFolderName);
            this.tabPageBlob.Controls.Add(this.buttonBlobUploadGetFile);
            this.tabPageBlob.Controls.Add(this.textBoxBlobUploadFilePath);
            this.tabPageBlob.Controls.Add(this.buttonBlobUpload);
            this.tabPageBlob.Controls.Add(this.labelBlobUploadPath);
            this.tabPageBlob.Location = new System.Drawing.Point(4, 29);
            this.tabPageBlob.Name = "tabPageBlob";
            this.tabPageBlob.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlob.Size = new System.Drawing.Size(1394, 745);
            this.tabPageBlob.TabIndex = 2;
            this.tabPageBlob.Text = "Blob";
            this.tabPageBlob.UseVisualStyleBackColor = true;
            // 
            // textBoxBlobVersionFolderName
            // 
            this.textBoxBlobVersionFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlobVersionFolderName.Location = new System.Drawing.Point(209, 65);
            this.textBoxBlobVersionFolderName.Name = "textBoxBlobVersionFolderName";
            this.textBoxBlobVersionFolderName.Size = new System.Drawing.Size(123, 30);
            this.textBoxBlobVersionFolderName.TabIndex = 34;
            this.textBoxBlobVersionFolderName.Text = "1.2.7.0";
            // 
            // labelBlobVersionFolderName
            // 
            this.labelBlobVersionFolderName.AutoSize = true;
            this.labelBlobVersionFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlobVersionFolderName.Location = new System.Drawing.Point(43, 68);
            this.labelBlobVersionFolderName.Name = "labelBlobVersionFolderName";
            this.labelBlobVersionFolderName.Size = new System.Drawing.Size(145, 25);
            this.labelBlobVersionFolderName.TabIndex = 33;
            this.labelBlobVersionFolderName.Text = "Version Folder:";
            // 
            // buttonBlobUploadGetFile
            // 
            this.buttonBlobUploadGetFile.Location = new System.Drawing.Point(929, 145);
            this.buttonBlobUploadGetFile.Name = "buttonBlobUploadGetFile";
            this.buttonBlobUploadGetFile.Size = new System.Drawing.Size(59, 32);
            this.buttonBlobUploadGetFile.TabIndex = 32;
            this.buttonBlobUploadGetFile.Text = "...";
            this.buttonBlobUploadGetFile.UseVisualStyleBackColor = true;
            this.buttonBlobUploadGetFile.Click += new System.EventHandler(this.ButtonBlobUploadGetFileClick);
            // 
            // textBoxBlobUploadFilePath
            // 
            this.textBoxBlobUploadFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBlobUploadFilePath.Location = new System.Drawing.Point(209, 145);
            this.textBoxBlobUploadFilePath.Name = "textBoxBlobUploadFilePath";
            this.textBoxBlobUploadFilePath.Size = new System.Drawing.Size(704, 30);
            this.textBoxBlobUploadFilePath.TabIndex = 31;
            this.textBoxBlobUploadFilePath.Text = "c:\\";
            this.textBoxBlobUploadFilePath.TextChanged += new System.EventHandler(this.TextBoxBlobUploadFilePathTextChanged);
            // 
            // buttonBlobUpload
            // 
            this.buttonBlobUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlobUpload.Location = new System.Drawing.Point(47, 193);
            this.buttonBlobUpload.Name = "buttonBlobUpload";
            this.buttonBlobUpload.Size = new System.Drawing.Size(101, 39);
            this.buttonBlobUpload.TabIndex = 29;
            this.buttonBlobUpload.Text = "Upload";
            this.buttonBlobUpload.UseVisualStyleBackColor = true;
            this.buttonBlobUpload.Click += new System.EventHandler(this.ButtonBlobUploadClick);
            // 
            // labelBlobUploadPath
            // 
            this.labelBlobUploadPath.AutoSize = true;
            this.labelBlobUploadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlobUploadPath.Location = new System.Drawing.Point(43, 148);
            this.labelBlobUploadPath.Name = "labelBlobUploadPath";
            this.labelBlobUploadPath.Size = new System.Drawing.Size(146, 25);
            this.labelBlobUploadPath.TabIndex = 0;
            this.labelBlobUploadPath.Text = "Local File Path:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(205, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(198, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItemClick);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialogMain";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 811);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Fred Azure Storage Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainFormClosing);
            this.Load += new System.EventHandler(this.FormMainLoad);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSas.ResumeLayout(false);
            this.tabPageSas.PerformLayout();
            this.tabPageTable.ResumeLayout(false);
            this.tabPageTable.PerformLayout();
            this.tabPageBlob.ResumeLayout(false);
            this.tabPageBlob.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSas;
        private System.Windows.Forms.TextBox textBoxAccountKey;
        private System.Windows.Forms.Label labelAccountKey;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.TabPage tabPageTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.Button buttonLoadTable;
        private System.Windows.Forms.TabPage tabPageBlob;
        private System.Windows.Forms.Label labelBlobUploadPath;
        private System.Windows.Forms.TextBox textBoxTableComments;
        private System.Windows.Forms.Label labelTableComments;
        private System.Windows.Forms.TextBox textBoxTableTargetDate;
        private System.Windows.Forms.Label labelTableTargetDate;
        private System.Windows.Forms.TextBox textBoxTableBlobUrl;
        private System.Windows.Forms.Label labelBlobUrl;
        private System.Windows.Forms.TextBox textBoxTableStatus;
        private System.Windows.Forms.Label labelTableStatus;
        private System.Windows.Forms.TextBox textBoxTableMode;
        private System.Windows.Forms.Label labelTableMode;
        private System.Windows.Forms.TextBox textBoxTableMachineName;
        private System.Windows.Forms.Label labelTableMachineName;
        private System.Windows.Forms.TextBox textBoxTableHCode;
        private System.Windows.Forms.Label labelTableHId;
        private System.Windows.Forms.TextBox textBoxTableHId;
        private System.Windows.Forms.Label labelTableHCode;
        private System.Windows.Forms.TextBox textBoxTableEnabled;
        private System.Windows.Forms.Label labelTableEnabled;
        private System.Windows.Forms.TextBox textBoxTableTimeStamp;
        private System.Windows.Forms.Label labelTableTimeStamp;
        private System.Windows.Forms.TextBox textBoxTableRowKey;
        private System.Windows.Forms.Label labelTableRowKey;
        private System.Windows.Forms.Button buttonTableInsert;
        private System.Windows.Forms.TextBox textBoxTablePartitionKey;
        private System.Windows.Forms.Label labelTablePartitionKey;
        private System.Windows.Forms.Button buttonTableUpdate;
        private System.Windows.Forms.Button buttonTableClear;
        private System.Windows.Forms.Button buttonBlobUploadGetFile;
        private System.Windows.Forms.TextBox textBoxBlobUploadFilePath;
        private System.Windows.Forms.Button buttonBlobUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.TextBox textBoxBlobVersionFolderName;
        private System.Windows.Forms.Label labelBlobVersionFolderName;
    }
}

