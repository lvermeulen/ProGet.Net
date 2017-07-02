using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DockerImage
    {
        public int Feed_Id { get; set; }
        public string Repository_Name { get; set; }
        public string Image_Digest { get; set; }
        public byte[] ManifestJson_Bytes { get; set; }
        public int Download_Count { get; set; }
        public DateTime Published_Date { get; set; }
    }
}
