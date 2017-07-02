using System.Collections.Generic;

namespace ProGet.Net.Native.Models
{
    public class NpmPackagesVersionsTags
    {
        public List<NpmPackage> NpmPackages { get; set; }
        public List<NpmPackageVersion> NpmPackageVersions { get; set; }
        public List<NpmPackageTag> NpmPackageTags { get; set; }
    }
}
