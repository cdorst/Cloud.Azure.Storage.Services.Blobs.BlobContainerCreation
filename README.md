# Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-blobcontainercr.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-blobcontainercr)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation)

## Description

Service responsible for creating a blob container

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-blob.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-blob) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.BlobContainerCreator)
[CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter](https://github.com/CDorst/Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/cloud-azure-storage-services-blobs-interfaces-clou.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/cloud-azure-storage-services-blobs-interfaces-clou) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.Interfaces.CloudBlobClientGetter)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation](https://www.nuget.org/packages/CDorst.Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation)

## Version

1.0.0

## Metaproject

Cloud.Azure.Storage.Services.Blobs.BlobContainerCreation is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

