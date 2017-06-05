// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DashboardPackagesLatest
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string Package_Id { get; set; }
        public string Version_Text { get; set; }
        public string Published_Date { get; set; }
        public string FeedType_Name { get; set; }
        public object Group_Id { get; set; }
    }
}