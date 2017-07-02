using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class BowerPackage
    {
        public int Feed_Id { get; set; }
        public string Package_Name { get; set; }
        public string Repository_Url { get; set; }
        public int Hit_Count { get; set; }
        public DateTime? LastRequested_Date { get; set; }
    }
}
