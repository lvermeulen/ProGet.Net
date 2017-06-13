// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NpmPackageLatest
    {
        public int Feed_Id { get; set; }
        public string Package_Name { get; set; }
        public string Scope_Name { get; set; }
        public int Download_Count { get; set; }
        public string Version_Text { get; set; }
        public string Published_Date { get; set; }
        public string PackageJson_Bytes { get; set; }
        public string PackageHash_Bytes { get; set; }
        public bool Cached_Indicator { get; set; }
        public int Package_Size { get; set; }
    }
}
