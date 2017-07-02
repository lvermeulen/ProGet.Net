// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class FeedRetentionRuleExtended
    {
        public int Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string FeedType_Name { get; set; }
        public int Sequence_Number { get; set; }
        public bool DeletePrereleaseVersions_Indicator { get; set; }
        public int? KeepVersions_Count { get; set; }
        public int? KeepUsedWithin_Days { get; set; }
        public string DeletePackageIds_Csv { get; set; }
        public string KeepPackageIds_Csv { get; set; }
        public bool DeleteCached_Indicator { get; set; }
        public long? SizeTrigger_KBytes { get; set; }
        public bool SizeExclusive_Indicator { get; set; }
        public int? TriggerDownload_Count { get; set; }
    }
}
