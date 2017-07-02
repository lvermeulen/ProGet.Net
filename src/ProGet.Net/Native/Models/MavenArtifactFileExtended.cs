using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class MavenArtifactFileExtended
    {
        public int Feed_Id { get; set; }
        public string GroupId_Text { get; set; }
        public string ArtifactId_Text { get; set; }
        public string Version_Text { get; set; }
        public string File_Type { get; set; }
        public string FileName_Text { get; set; }
        public byte[] File_SHA1_Bytes { get; set; }
        public byte[] File_MD5_Bytes { get; set; }
        public long File_Size { get; set; }
        public DateTime Updated_Date { get; set; }
        public bool Cached_Indicator { get; set; }
        public int Download_Count { get; set; }
        public DateTime? LastDownloaded_Date { get; set; }
    }
}
