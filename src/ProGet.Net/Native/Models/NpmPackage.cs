// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NpmPackage
    {
        public int Package_Id { get; set; }
        public int Feed_Id { get; set; }
        public string Package_Name { get; set; }
        public int Download_Count { get; set; }
        public string Scope_Name { get; set; }
    }
}
