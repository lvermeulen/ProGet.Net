// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class User
    {
        public string User_Name { get; set; }
        public string Display_Name { get; set; }
        public object Email_Address { get; set; }
        public string Salt_Bytes { get; set; }
        public string Password_Bytes { get; set; }
        public bool LegacyPassword_Indicator { get; set; }
    }
}