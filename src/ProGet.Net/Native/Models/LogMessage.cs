// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class LogMessage
    {
        public int LogMessage_Id { get; set; }
        public bool Read_Indicator { get; set; }
        public string Logged_Date { get; set; }
        public string Message_Text { get; set; }
        public object Category_Name { get; set; }
        public int Message_Level { get; set; }
        public string Details_Bytes { get; set; }
        public object Feed_Id { get; set; }
        public object Feed_Name { get; set; }
        public object FeedType_Name { get; set; }
        public object Connector_Id { get; set; }
        public object Connector_Name { get; set; }
        public object Connector_Url { get; set; }
        public object ConnectorType_Name { get; set; }
    }
}
