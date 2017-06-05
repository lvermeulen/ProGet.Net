// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class Role
    {
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public string Role_Description { get; set; }
        public bool FeedScopable_Indicator { get; set; }
    }
}