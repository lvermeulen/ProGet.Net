// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class FeedConnectorExtended
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public bool Feed_Active_Indicator { get; set; }
        public string Connector_Name { get; set; }
        public int Connector_Id { get; set; }
        public int Sequence_Number { get; set; }
        public string User_Name { get; set; }
        public object Password_Bytes { get; set; }
        public int Timeout_Period { get; set; }
        public object Filter_Csv { get; set; }
        public string Connector_Url { get; set; }
        public object IndexUpdated_Date { get; set; }
        public string Status_Code { get; set; }
        public int Package_Count { get; set; }
        public string LastTest_Date { get; set; }
        public bool MetadataCache_Enabled_Indicator { get; set; }
    }
}
