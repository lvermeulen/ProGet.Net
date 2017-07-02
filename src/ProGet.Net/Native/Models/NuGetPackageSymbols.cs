// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackageSymbols
    {
        public int Feed_Id { get; set; }
        public byte[] Symbol_Id { get; set; }
        public string SymbolFileName_Text { get; set; }
        public int Symbol_Age { get; set; }
        public string Package_Id { get; set; }
        public string Package_Version_Text { get; set; }
        public string Package_SymbolFilePath_Text { get; set; }
    }
}
