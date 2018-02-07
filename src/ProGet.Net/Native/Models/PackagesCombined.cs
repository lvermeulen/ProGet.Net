using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class PackagesCombined
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string Package_Id { get; set; }
        public string Version_Text { get; set; }
        public DateTime? Published_Date { get; set; }
        public string FeedType_Name { get; set; }
        public int Download_Count { get; set; }
        public string Group_Id { get; set; }
    }
}
