using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetFeedExtended
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string Feed_Description { get; set; }
        public bool Active_Indicator { get; set; }
        public bool Cache_Connectors_Indicator { get; set; }
        public string FeedType_Name { get; set; }
        public string DropPath_Text { get; set; }
        public string FeedPathOverride_Text { get; set; }
        public string APIKey_Text { get; set; }
        public bool? SymbolServerEnabled_Indicator { get; set; }
        public bool? StripSymbolFiles_Indicator { get; set; }
        public string PackageStoreConfiguration_Xml { get; set; }
        public bool? Legacy_Indicator { get; set; }
        public byte[] SyncToken_Bytes { get; set; }
        public string SyncTarget_Url { get; set; }
        public DateTime? LastSync_Date { get; set; }
        public bool? AllowUnknownLicenses_Indicator { get; set; }
    }
}
