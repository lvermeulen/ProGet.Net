using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NpmConnectorPackage
    {
        public int Connector_Id { get; set; }
        public string Package_Name { get; set; }
        public string Package_Version { get; set; }
        public DateTime Modified_Date { get; set; }
        public byte[] PackageJson_Bytes { get; set; }
    }
}
