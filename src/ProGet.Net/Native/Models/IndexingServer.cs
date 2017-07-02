using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class IndexingServer
    {
        public string Server_Name { get; set; }
        public string IPAddress_Text { get; set; }
        public DateTime LastUpdated_Date { get; set; }
        public bool Primary_Indicator { get; set; }
    }
}
