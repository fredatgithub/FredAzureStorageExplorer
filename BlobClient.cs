using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FredAzureStorageExplorer
{
    public class BlobClient : IBlobClient
    {
        public BlobClient()
        {

        }

        /// <summary>
        /// Upload on blob storage from local File
        /// </summary>
        /// <param name="localFilePath"></param>
        /// <param name="metadata"></param>
        /// <param name="archive"></param>
        /// <param name="blobFilePath"></param>
        /// <returns></returns>
        public async Task UploadFromFileAsync(string blobFilePath, string localFilePath, IDictionary<string, string> metadata = null, bool archive = false)
        {
            // TODO: manage metadata

            try
            {
                var blob = new CloudBlockBlob(new Uri(blobFilePath));
                if (File.Exists(localFilePath))
                {
                    var msWrite = new MemoryStream(File.ReadAllBytes(localFilePath));
                    msWrite.Position = 0;
                    using (msWrite)
                    {
                        await blob.UploadFromStreamAsync(msWrite);
                    }
                }

                Trace.TraceInformation("{0} - upload completed on {1}", localFilePath, blobFilePath);
            }
            catch (StorageException e)
            {
                Trace.TraceError("UploadFromFileAsync - {0}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Download backup from blob storage
        /// </summary>
        /// <param name="blobFilePath">Source path in the cloud</param>
        /// <param name="localFilePath">Target file</param>
        /// <param name="fileMode"></param>
        /// <returns></returns>
        public async Task DownloadToFileAsync(string blobFilePath, string localFilePath, FileMode fileMode = FileMode.Create)
        {
            // TODO: manage metadata

            try
            {
                var blob = new CloudBlockBlob(new Uri(blobFilePath));
                if (blob.Exists())
                {
                    blob.FetchAttributes();
                    await blob.DownloadToFileAsync(localFilePath, fileMode);
                }


                Trace.TraceInformation("{0} - download completed from {1}", localFilePath, blobFilePath);
            }
            catch (StorageException e)
            {
                Trace.TraceError("DownloadToFileAsync - {0}", e.Message);
                throw;
            }
        }

        /// <summary>
        /// Get blob properties
        /// </summary>
        /// <param name="blobFilePath"></param>
        /// <returns></returns>
        public async Task<BlobProperties> GetBlobPropertiesAsync(string blobFilePath)
        {
            var blob = new CloudBlockBlob(new Uri(blobFilePath));
            await blob.Container.FetchAttributesAsync();
            return blob.Properties;
        }
    }
}
