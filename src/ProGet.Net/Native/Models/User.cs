// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class User
    {
        public string User_Name { get; set; }
        public string Display_Name { get; set; }
        public string Email_Address { get; set; }
        public byte[] Salt_Bytes { get; set; }
        public byte[] Password_Bytes { get; set; }
        public bool LegacyPassword_Indicator { get; set; }
    }
}