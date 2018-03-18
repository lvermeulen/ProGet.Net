using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackageV2Extended
    {
        public int NuGetPackageV2_Id { get; set; }
        public int Feed_Id { get; set; }
        public string Package_Id { get; set; }
        public string Version_Text { get; set; }
        public string FullVersion_Text { get; set; }
        public DateTime? Published_Date { get; set; }
        public int Package_Size { get; set; }
        public int Download_Count { get; set; }
        public byte[] PackageHash_SHA1_Bytes { get; set; }
        public byte[] PackageHash_SHA512_Bytes { get; set; }
        public string TargetFrameworks_Text { get; set; }
        public byte[] Nuspec_Bytes { get; set; }
        public bool Symbols_Indicator { get; set; }
        public bool Source_Indicator { get; set; }
        public bool Cached_Indicator { get; set; }
        public bool Listed_Indicator { get; set; }
        public DateTime? LastDownloaded_Date { get; set; }
        public bool LatestAbsoluteVersion_Indicator { get; set; }
        public bool LatestStableVersion_Indicator { get; set; }
    }
}
