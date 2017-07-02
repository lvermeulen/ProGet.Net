using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class DockerRepository
    {
        public int Feed_Id { get; set; }
        public string Repository_Name { get; set; }
        public int? Download_Count { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Image_Count { get; set; }
        public string ShortDescription_Text { get; set; }
        public string FullDescription_Text { get; set; }
    }
}
