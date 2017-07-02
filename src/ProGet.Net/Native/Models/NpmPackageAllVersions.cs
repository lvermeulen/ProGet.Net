using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NpmPackageAllVersions
    {
        public int Feed_Id { get; set; }
        public string Package_Name { get; set; }
        public string Scope_Name { get; set; }
        public string Version_Text { get; set; }
        public DateTime Published_Date { get; set; }
        public int Download_Count { get; set; }
        public DateTime? LastDownloaded_Date { get; set; }
        public byte[] PackageHash_Bytes { get; set; }
        public byte[] PackageJson_Bytes { get; set; }
        public bool Cached_Indicator { get; set; }
        public long? Package_Size { get; set; }
    }
}
