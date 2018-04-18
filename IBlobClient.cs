using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FredAzureStorageExplorer
{
    public interface IBlobClient
    {
        /// <summary>
        /// Upload from file 
        /// </summary>
        /// <param name="localFilePath"></param>
        /// <param name="metadata"></param>
        /// <param name="archive"></param>
        /// <param name="blobFilePath"></param>
        /// <returns></returns>
        Task UploadFromFileAsync(string blobFilePath, string localFilePath, IDictionary<string, string> metadata = null, bool archive = false);

        /// <summary>
        /// Download from file
        /// </summary>
        /// <param name="blobFilePath"></param>
        /// <param name="localFilePath"></param>
        /// <param name="fileMode"></param>
        /// <returns></returns>
        Task DownloadToFileAsync(string blobFilePath, string localFilePath, FileMode fileMode = FileMode.Create);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="blobFilePath"></param>
        /// <returns></returns>
        Task<BlobProperties> GetBlobPropertiesAsync(string blobFilePath);
    }
}