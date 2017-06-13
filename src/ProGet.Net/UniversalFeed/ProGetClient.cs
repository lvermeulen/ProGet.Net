using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json.Linq;
using ProGet.Net.Common;
using ProGet.Net.UniversalFeed.Models;

// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        private IFlurlClient GetUniversalFeedApiClient(string path, object queryParamValues = null) => GetApiClient("/upack")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues, Flurl.NullValueHandling.NameOnly)
            .AllowAnyHttpStatus();

        public async Task<IEnumerable<Package>> ListUniversalFeedPackagesAsync(string feedName, string group = null, string name = null, int? count = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group), group),
                new NamedValue(nameof(name), name),
                new NamedValue(nameof(count), count)
            );

            return await GetUniversalFeedApiClient($"{feedName}/packages", queryParamValues)
                .GetJsonAsync<IEnumerable<Package>>();
        }

        public async Task<IEnumerable<PackageVersion>> ListUniversalFeedVersionsAsync(string feedName, string group = null, string name = null, int? count = null, string version = null, bool? includeFileList = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group), group),
                new NamedValue(nameof(name), name),
                new NamedValue(nameof(count), count),
                new NamedValue(nameof(version), version),
                new NamedValue(nameof(includeFileList), includeFileList.ToTrueFalse())
            );

            return await GetUniversalFeedApiClient($"{feedName}/versions", queryParamValues)
                .GetJsonAsync<IEnumerable<PackageVersion>>();
        }

        public async Task<PackageDownload> DownloadPackageSpecificVersionAsync(string feedName, string groupName, string packageName, string packageVersion, ContentOnlyTypes? contentOnly = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(contentOnly), contentOnly)
            );

            string path = groupName == null
                ? $"{feedName}/download/{packageName}/{packageVersion}"
                : $"{feedName}/download/{groupName}/{packageName}/{packageVersion}";

            var response = await GetUniversalFeedApiClient(path, queryParamValues)
                .GetAsync();

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return new PackageDownload
            {
                FileName = response.Content.Headers.ContentDisposition.FileName,
                Bytes = await response.Content.ReadAsByteArrayAsync()
            };
        }

        public async Task<PackageDownload> DownloadPackageLatestVersionAsync(string feedName, string groupName, string packageName, ContentOnlyTypes? contentOnly = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(contentOnly), contentOnly),
                new NamedValue("latest")
            );

            string path = groupName == null
                ? $"{feedName}/download/{packageName}"
                : $"{feedName}/download/{groupName}/{packageName}";

            var response = await GetUniversalFeedApiClient(path, queryParamValues)
                .GetAsync();

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return new PackageDownload
            {
                FileName = response.Content.Headers.ContentDisposition.FileName,
                Bytes = await response.Content.ReadAsByteArrayAsync()
            };
        }

        public async Task<bool> UploadPackageAsync(string feedName, PackageUpload packageUpload)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue("content-url", packageUpload.Contenturl),
                new NamedValue(nameof(PackageUpload.Group), packageUpload.Group),
                new NamedValue(nameof(PackageUpload.Name), packageUpload.Name),
                new NamedValue(nameof(PackageUpload.Version), packageUpload.Version),
                new NamedValue(nameof(PackageUpload.Dependencies), packageUpload.Dependencies)
            );

            var response = await GetUniversalFeedApiClient($"{feedName}/upload", queryParamValues)
                .PutJsonAsync(new JObject("content-b64", packageUpload.Contentb64));

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePackageAsync(string groupName, string packageName, string packageVersion)
        {
            string path = groupName == null
                ? $"delete/{packageName}/{packageVersion}"
                : $"delete/{groupName}/{packageName}/{packageVersion}";

            var response = await GetUniversalFeedApiClient(path)
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<Package>> SearchPackagesAsync(string feedName, string query, int? count = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(query), query),
                new NamedValue(nameof(count), count)
            );

            return await GetUniversalFeedApiClient($"{feedName}/search", queryParamValues)
                .GetJsonAsync<IEnumerable<Package>>();
        }
    }
}
