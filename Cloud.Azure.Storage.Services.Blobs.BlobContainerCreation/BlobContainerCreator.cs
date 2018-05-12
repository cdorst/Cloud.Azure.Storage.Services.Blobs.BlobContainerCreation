// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator;
using Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Threading.Tasks;

namespace Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation
{
    /// <summary>Service responsible for creating a blob container</summary>
    public class BlobContainerCreator : ICloudStorageAccountGetter
    {
        private readonly CloudBlobClient _blobClient;

        public BlobContainerCreator(ICloudBlobClientGetter cloudBlobClientGetter)
        {
            _blobClient = cloudBlobClientGetter?.BlobClient ?? throw new ArgumentNullException(nameof(cloudBlobClientGetter));
        }

        /// <summary>Returns Azure Storage account instance</summary>
        public async Task CreateContainer(string containerName) => await _blobClient.GetContainerReference(containerName).CreateIfNotExistsAsync();
    }
}
