// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DashboardFeed
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string FeedType_Name { get; set; }
        public int Package_Download_Count { get; set; }
        public int Package_Count { get; set; }
        public int Feed_Size { get; set; }
        public int Cache_Size { get; set; }
        public bool Active_Indicator { get; set; }
    }
}