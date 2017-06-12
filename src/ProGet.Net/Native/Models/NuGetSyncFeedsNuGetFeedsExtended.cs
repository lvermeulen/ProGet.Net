using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetSyncFeedsNuGetFeedsExtended
    {
        public List<NuGetSyncFeed> NuGetSyncFeeds { get; set; }
        public List<NuGetFeedExtended> NuGetFeeds_Extended { get; set; }
    }
}
