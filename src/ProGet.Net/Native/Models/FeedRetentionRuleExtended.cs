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
        public int KeepVersions_Count { get; set; }
        public object KeepUsedWithin_Days { get; set; }
        public object DeletePackageIds_Csv { get; set; }
        public object KeepPackageIds_Csv { get; set; }
        public bool DeleteCached_Indicator { get; set; }
        public int SizeTrigger_KBytes { get; set; }
        public bool SizeExclusive_Indicator { get; set; }
        public object TriggerDownload_Count { get; set; }
    }
}
