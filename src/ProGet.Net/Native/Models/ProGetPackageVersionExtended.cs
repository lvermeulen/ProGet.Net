using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class ProGetPackageVersionExtended
    {
        public int ProGetPackage_Id { get; set; }
        public string Package_Name { get; set; }
        public string Group_Name { get; set; }
        public string Version_Text { get; set; }
        public byte[] PackageHash_Bytes { get; set; }
        public byte[] PackageMetadata_Bytes { get; set; }
        public DateTime Published_Date { get; set; }
        public long Package_Size { get; set; }
        public int Download_Count { get; set; }
        public bool Cached_Indicator { get; set; }
    }
}
