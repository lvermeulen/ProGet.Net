// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class ProGetPackage
    {
        public int ProGetPackage_Id { get; set; }
        public int Feed_Id { get; set; }
        public string Group_Name { get; set; }
        public string Package_Name { get; set; }
        public string Title_Text { get; set; }
        public string Description_Text { get; set; }
        public string IconUrl_Text { get; set; }
        public string LatestVersion_Text { get; set; }
        public int Download_Count { get; set; }
    }
}
