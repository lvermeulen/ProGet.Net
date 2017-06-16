using Flurl;
using Flurl.Http;

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

        private void ErrorHandler(HttpCall call)
        {
            if (call.Completed)
            {
                string responseContent = call.Response.Content.ReadAsStringAsync().Result;
                call.ExceptionHandled = true;

                throw new FlurlHttpException(call, responseContent, call.Exception);
            }
        }
    }
}
