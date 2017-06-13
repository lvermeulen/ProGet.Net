// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackageExtended
    {
        public string Package_Id { get; set; }
        public string Version_Text { get; set; }
        public string TargetFrameworks_Text { get; set; }
        public string Published_Date { get; set; }
        public int Package_Size { get; set; }
        public string PackageHash_Bytes { get; set; }
        public string PackageHash_SHA1_Bytes { get; set; }
        public int Feed_Id { get; set; }
        public int Version_Download_Count { get; set; }
        public int Total_Download_Count { get; set; }
        public string NuspecFile_Bytes { get; set; }
        public bool Symbols_Indicator { get; set; }
        public bool Source_Indicator { get; set; }
        public bool Cached_Indicator { get; set; }
        public string Feed_Name { get; set; }
        public object Feed_Description { get; set; }
        public string FeedType_Name { get; set; }
        public bool Prerelease_Indicator { get; set; }
        public bool Listed_Indicator { get; set; }
        public string LastDownloaded_Date { get; set; }
        public bool LatestAbsoluteVersion_Indicator { get; set; }
        public bool LatestStableVersion_Indicator { get; set; }
    }
}
