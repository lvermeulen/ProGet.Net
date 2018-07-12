using System;

namespace ProGet.Net.UniversalFeed.Models
{
    [Flags]
    public enum UniversalFeedServices
    {
        None = 0,
        VirtualPackages = 1,    // supports virtual packages, and injects the isVirtual property in the list endpoints
        RemotePackages = 2,     // supports remote packages (e.g. connectors in ProGet), and injects the isLocal and  isCached properties in the list endpoints
        UploadPackage = 4,      // supports simple uploading (a complete package file only)
        UploadContents = 8,     // supports partial uploading (contents, metadata, etc)
        Delete = 16,             // supports deleting packages
        DownloadContents = 32    // supports downloading of individual files or "contentOnly" of a package
    }
}
