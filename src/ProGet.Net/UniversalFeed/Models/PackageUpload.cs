using Newtonsoft.Json;

namespace ProGet.Net.UniversalFeed.Models
{
    public class PackageUpload
    {
        [JsonProperty("content-b64")]
        public string Contentb64 { get; set; } // A string representing the contents as a base64-encoded ZIP archive; this is not valid with application/zip Content-Type, and will be considered duplicative if content-url is specified
        [JsonProperty("content-url")]
        public string Contenturl { get; set; } // A url where content can be downloaded from as a ZIP archive; this is not valid with application/zip Content-Type, and will be considered duplicative if content-b64 is specified
        public string Group { get; set; } // This may also be specified as the first path following the endpoint
        public string Name { get; set; } // This may also be specified as either the last or second-to-last path
        public string Version { get; set; } // This may also be specified as either the last path
        public string[] Dependencies { get; set; } // When specified in JSON, it should be an array; otherwise(querystring or form format), it should be a comma-separated string of package identifiers
    }
}
