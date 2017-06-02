namespace ProGet.Net.PackagePromotion.Models
{
    public class Package
    {
        public string PackageName { get; set; } // A string representing the name or ID of the package
        public string GroupName { get; set; } // A string representing the group of the package for Universal and Maven feeds and the scope of the package for npm feeds.This property is omitted for all other feed types
        public FeedTypes PackageType { get; set; } // The feed type of the package, one of: upack, powershell, nuget, chocolatey, maven, npm, bower, or docker
        public string Version { get; set; } // A string representing the version of the package
        public Promotion[] Promotions { get; set; } // An array of Promotion objects representing a package promotion
    }
}
