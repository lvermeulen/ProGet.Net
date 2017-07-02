using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class NuGetPackagesExtendedNuGetPackageSymbols
    {
        public List<NuGetPackageExtended> NuGetPackages_Extended { get; set; }
        public List<NuGetPackageSymbols> NuGetPackageSymbols { get; set; }
    }
}
