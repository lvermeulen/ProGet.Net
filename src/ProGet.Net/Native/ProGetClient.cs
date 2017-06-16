using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;

// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        private IFlurlClient GetNativeApiClient(string path, object queryParamValues = null) => GetApiClient("/api/json")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues)
            .ConfigureClient(settings => settings.OnError = ErrorHandler);

        private async Task<TResult> ExecuteNativeApiMethodAsync<TResult>(string nativeApiMethodName, IDictionary<string, object> parameters = null) => 
            await GetNativeApiClient(nativeApiMethodName, parameters)
                .GetJsonAsync<TResult>()
                .ConfigureAwait(false);

        private async Task<bool> ExecuteNativeApiMethodAsync(string nativeApiMethodName, IDictionary<string, object> parameters = null)
        {
            var response = await GetNativeApiClient(nativeApiMethodName, parameters)
                .GetAsync()
                .ConfigureAwait(false);

            return response.IsSuccessStatusCode;
        }
    }
}
