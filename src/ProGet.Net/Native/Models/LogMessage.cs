using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class LogMessage
    {
        public int LogMessage_Id { get; set; }
        public bool Read_Indicator { get; set; }
        public DateTime Logged_Date { get; set; }
        public string Message_Text { get; set; }
        public string Category_Name { get; set; }
        public int Message_Level { get; set; }
        public byte[] Details_Bytes { get; set; }
        public int? Feed_Id { get; set; }
        public int? Connector_Id { get; set; }
    }
}
