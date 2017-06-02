namespace ProGet.Net.UniversalFeed.Models
{
    public class PackageVersion
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Downloads { get; set; }
        public string Published { get; set; }
        public bool IsLocal { get; set; }
        public bool IsCached { get; set; }
    }
}
