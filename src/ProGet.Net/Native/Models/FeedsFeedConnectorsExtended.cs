using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class FeedsFeedConnectorsExtended
    {
        public List<Feed> Feeds { get; set; }
        public List<FeedConnectorExtended> FeedConnectors_Extended { get; set; }
    }
}
