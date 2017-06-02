// ReSharper disable InconsistentNaming

namespace ProGet.Net.PackagePromotion.Models
{
    public class PackagePromotionContents
    {
        public string packageName { get; set; }  
        public string groupName { get; set; }  
        public string version { get; set; }  
        public string fromFeed { get; set; }  
        public string toFeed { get; set; }  
        public string comments { get; set; } 
    }
}
