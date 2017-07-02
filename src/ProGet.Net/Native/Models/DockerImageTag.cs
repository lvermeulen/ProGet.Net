// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DockerImageTag
    {
        public int Feed_Id { get; set; }
        public string Repository_Name { get; set; }
        public string Tag_Name { get; set; }
        public string Image_Digest { get; set; }
    }
}
