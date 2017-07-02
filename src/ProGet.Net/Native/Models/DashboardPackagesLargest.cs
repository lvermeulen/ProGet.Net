// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DashboardPackagesLargest
    {
        public int Feed_Id { get; set; }
        public string Package_Name { get; set; }
        public long? Total_Size { get; set; }
    }
}
