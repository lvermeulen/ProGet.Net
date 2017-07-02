// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class FeedPackageFilter
    {
        public int Feed_Id { get; set; }
        public int Sequence_Number { get; set; }
        public string PackageFilter_Name { get; set; }
        public string PackageFilter_Configuration { get; set; }
    }
}
