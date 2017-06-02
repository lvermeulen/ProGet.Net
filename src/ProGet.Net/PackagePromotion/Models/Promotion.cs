using System;

namespace ProGet.Net.PackagePromotion.Models
{
    public class Promotion
    {
        public string FromFeed { get; set; } // A string representing the name of the feed the promotion originated from
        public string ToFeed { get; set; } // A string representing the name of the feed the package was promoted to
        public DateTime Date { get; set; } // The UTC date of the promotion in ISO 8601 format (yyyy-MM-ddThh:mm:ss)
        public string User { get; set; } // A string representing the user who promoted the package.Packages promoted via this API will by noted with SYSTEM as the user
        public string Comments { get; set; } // A string containing comments submitted when the promotion occurred
        public int Id { get; set; } // An integer representing a unique identifier of the promotion
    }
}
