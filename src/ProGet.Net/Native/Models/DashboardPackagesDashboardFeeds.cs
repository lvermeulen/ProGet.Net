using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DashboardPackagesDashboardFeeds
    {
        public List<DashboardPackagesLatest> DashboardPackages_Latest { get; set; }
        public List<DashboardFeed> DashboardFeeds { get; set; }
    }
}
