// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class MavenArtifactExtended
    {
        public int Feed_Id { get; set; }
        public string GroupId_Text { get; set; }
        public string ArtifactId_Text { get; set; }
        public string Name_Text { get; set; }
        public string Description_Text { get; set; }
        public object ReleaseVersion_Text { get; set; }
        public string LatestVersion_Text { get; set; }
        public string Updated_Date { get; set; }
        public int Download_Count { get; set; }
    }
}
