// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class Connector
    {
        public int Connector_Id { get; set; }
        public string Connector_Name { get; set; }
        public string Connector_Url { get; set; }
        public string FeedType_Name { get; set; }
        public string User_Name { get; set; }
        public object Password_Bytes { get; set; }
        public int Timeout_Period { get; set; }
        public object Filter_Csv { get; set; }
        public object IndexUpdated_Date { get; set; }
        public string Status_Code { get; set; }
        public object Package_Count { get; set; }
        public object LastTest_Date { get; set; }
        public int MetadataCache_Minutes { get; set; }
        public int MetadataCache_Count { get; set; }
        public bool MetadataCache_Enabled_Indicator { get; set; }
    }
}
