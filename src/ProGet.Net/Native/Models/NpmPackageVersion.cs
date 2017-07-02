using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NpmPackageVersion
    {
        public int Package_Id { get; set; }
        public string Version_Text { get; set; }
        public byte[] PackageJson_Bytes { get; set; }
        public int Download_Count { get; set; }
        public DateTime Published_Date { get; set; }
        public byte[] PackageHash_Bytes { get; set; }
        public DateTime? LastDownloaded_Date { get; set; }
        public long? Package_Size { get; set; }
        public bool Cached_Indicator { get; set; }
    }
}
