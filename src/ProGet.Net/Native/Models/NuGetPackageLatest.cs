// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackageLatest
    {
        public int Feed_Id { get; set; }
        public string Package_Id { get; set; }
        public string Version_Text { get; set; }
        public string TargetFrameworks_Text { get; set; }
        public string Published_Date { get; set; }
        public int Package_Size { get; set; }
        public string NuspecFile_Bytes { get; set; }
        public string PackageHash_Bytes { get; set; }
        public string PackageHash_SHA1_Bytes { get; set; }
        public bool Symbols_Indicator { get; set; }
        public bool Source_Indicator { get; set; }
        public bool Cached_Indicator { get; set; }
        public bool Prerelease_Indicator { get; set; }
        public object LastDownloaded_Date { get; set; }
        public int Version_Download_Count { get; set; }
        public int Total_Download_Count { get; set; }
    }
}
