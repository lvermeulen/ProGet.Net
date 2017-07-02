using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DockerBlob
    {
        public int Feed_Id { get; set; }
        public string Blob_Digest { get; set; }
        public int Download_Count { get; set; }
        public DateTime? LastRequested_Date { get; set; }
        public long Blob_Size { get; set; }
    }
}
