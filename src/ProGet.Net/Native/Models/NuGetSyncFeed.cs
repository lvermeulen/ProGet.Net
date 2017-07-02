using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetSyncFeed
    {
        public int Feed_Id { get; set; }
        public string Sync_Url { get; set; }
        public string RemoteFeed_Name { get; set; }
        public byte[] RemoteFeed_APIKey_Bytes { get; set; }
        public int Sync_Frequency_Minutes { get; set; }
        public bool Active_Indicator { get; set; }
        public DateTime? Last_Sync_Date { get; set; }
    }
}
