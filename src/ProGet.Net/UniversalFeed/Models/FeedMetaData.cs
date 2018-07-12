namespace ProGet.Net.UniversalFeed.Models
{
    public class FeedMetaData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public int PackageCount { get; set; }
        public int PackageVersionCount { get; set; }
        public UniversalFeedServices Services { get; set; }
    }
}
