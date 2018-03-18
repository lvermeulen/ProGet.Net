// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackageSymbolsV2Extended
    {
        public int Feed_Id { get; set; }
        public int Symbol_Id { get; set; }
        public string SymbolFileName_Text { get; set; }
        public int Symbol_Age { get; set; }
        public int NuGetPackageV2_Id { get; set; }
        public int Package_Id { get; set; }
        public string Package_Version_Text { get; set; }
        public string Package_SymbolFilePath_Text { get; set; }
    }
}
