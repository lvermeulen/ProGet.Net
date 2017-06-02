using Flurl;

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        private readonly string _url;
        private readonly string _apiKey;

        public ProGetClient(string url, string apiKey)
        {
            _url = url;
            _apiKey = apiKey;
        }

        private Url GetApiClient(string basePath) => new Url(_url)
            .AppendPathSegment(basePath)
            .SetQueryParam("key", _apiKey);
    }
}
