using System;
using Microsoft.WindowsAzure.Storage.Table;

namespace FredAzureStorageExplorer
{
    internal class UpdateEntity : TableEntity
    {
        /// <summary>Create a new update entity</summary>
        /// <param name="hId">The ID</param>
        /// <param name="hCode">The code</param>
        /// <param name="machineId">The ID of the pc running the application</param>
        /// <param name="version">The version used as the Row Key</param>
        /// <param name="targetDate">Targeted date for installation</param>
        /// <param name="accessMode">The mode to install the new version (Unknown, Immediately or AtNight ) from the AccessMode enumation</param>
        /// <param name="blobUrl">The url to get the new version from (MSI file)</param>
        /// <param name="status">The status of the installation (New, Processed, Failed, InProcess, Unknown) from the UpdateStatus enumeration</param>
        /// <param name="appExist">Enable or disable</param>
        /// <param name="comments">Any comment</param>
        public UpdateEntity(string hId, string hCode, string machineId, string version, DateTime? targetDate = null, UpdateMode accessMode = UpdateMode.Unknown, UpdateStatus status = UpdateStatus.Unknown, string blobUrl = "", bool appExist = false, string comments = "")
        {
            PartitionKey = machineId;
            RowKey = version;
            MachineName = Environment.MachineName;
            HId = hId;
            HCode = hCode;
            Mode = (int)accessMode;
            Status = (int)status;
            BlobUrl = blobUrl;
            Enabled = appExist;
            Comments = comments;
            if (targetDate != null)
            {
                TargetDate = targetDate;
            }
        }

        public UpdateEntity() { }

        /// <summary>The Id</summary>
        public string HId { get; set; }

        /// <summary>The code</summary>
        public string HCode { get; set; }

        /// <summary>
        /// May be empty.
        /// The update file must be downloaded after the given date.
        /// </summary>
        public DateTime? TargetDate { get; set; }

        /// <summary>
        /// Immediately : the update is run right after the download
        /// </summary>
        public int Mode { get; set; }

        /// <summary>URL of the ".msi" file in the blob container</summary>
        public string BlobUrl { get; set; }

        /// <summary>
        /// Enumeration UpdateStatus:
        /// NEW: determined if there is a new version to be installed
        /// PROCESSED: there is no version to install
        /// Failed: if the installation has failed
        /// InProcess: installation launched but not complete
        /// Unknown: any other case
        /// </summary>
        public int Status { get; set; }

        /// <summary>The name of machine (workstation or server)</summary>
        public string MachineName { get; set; }

        /// <summary>Boolean which specifies if the application exists or not</summary>
        public bool Enabled { get; set; }

        /// <summary>Column used for comments</summary>
        public string Comments { get; set; }
    }
}