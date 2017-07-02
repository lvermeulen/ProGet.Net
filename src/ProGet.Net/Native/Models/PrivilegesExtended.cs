// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class PrivilegesExtended
    {
        public int Privilege_Id { get; set; }
        public string Principal_Name { get; set; }
        public string PrincipalType_Code { get; set; }
        public string PrivilegeType_Code { get; set; }
        public int UserDirectory_Id { get; set; }
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
        public int? Feed_Id { get; set; }
        public string Feed_Name { get; set; }
    }
}
