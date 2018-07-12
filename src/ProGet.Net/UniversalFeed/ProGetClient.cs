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
            .ConfigureClient(settings => settings.OnError = ErrorHandler);

        public async Task<IEnumerable<Package>> UniversalFeed_ListPackagesAsync(string feedName, string group = null, string name = null, int? count = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(group), group),
                new NamedValue(nameof(name), name),
                new NamedValue(nameof(count), count)
            );

            return await GetUniversalFeedApiClient($"{feedName}/packages", queryParamValues)
                .GetJsonAsync<IEnumerable<Package>>();
        }

        public async Task<IEnumerable<PackageVersion>> UniversalFeed_ListVersionsAsync(string feedName, string group = null, string name = null, int? count = null, string version = null, bool? includeFileList = null)
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

        private async Task<PackageDownload> DownloadPackageAsync(string path, object queryParamValues = null)
        {
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

        private string GetDownloadPath(string feedName, string groupName, string packageName, string packageVersion, string downloadSegmentName)
        {
            string packageVersionString = packageVersion == null
                ? ""
                : $"/{packageVersion}";

            return groupName == null
                ? $"{feedName}/{downloadSegmentName}/{packageName}{packageVersionString}"
                : $"{feedName}/{downloadSegmentName}/{groupName}/{packageName}{packageVersionString}";
        }

        private string GetPackageDownloadPath(string feedName, string groupName, string packageName, string packageVersion = null) => 
            GetDownloadPath(feedName, groupName, packageName, packageVersion, "download");

        private string GetVirtualPackageDownloadPath(string feedName, string groupName, string packageName, string packageVersion = null) => 
            GetDownloadPath(feedName, groupName, packageName, packageVersion, "download-vpack");

        public async Task<PackageDownload> UniversalFeed_DownloadPackageSpecificVersionAsync(string feedName, string groupName, string packageName, string packageVersion, ContentOnlyTypes? contentOnly = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(contentOnly), contentOnly)
            );

            return await DownloadPackageAsync(GetPackageDownloadPath(feedName, groupName, packageName, packageVersion), queryParamValues);
        }

        public async Task<PackageDownload> UniversalFeed_DownloadPackageLatestVersionAsync(string feedName, string groupName, string packageName, ContentOnlyTypes? contentOnly = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(contentOnly), contentOnly),
                new NamedValue("latest")
            );

            return await DownloadPackageAsync(GetPackageDownloadPath(feedName, groupName, packageName), queryParamValues);
        }

        public async Task<bool> UniversalFeed_UploadPackageAsync(string feedName, PackageUpload packageUpload)
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

        public async Task<bool> UniversalFeed_DeletePackageAsync(string groupName, string packageName, string packageVersion)
        {
            string path = groupName == null
                ? $"delete/{packageName}/{packageVersion}"
                : $"delete/{groupName}/{packageName}/{packageVersion}";

            var response = await GetUniversalFeedApiClient(path)
                .DeleteAsync();

            return response.IsSuccessStatusCode;
        }

        public async Task<object> UniversalFeed_DownloadVirtualPackageSpecificVersionAsync(string feedName, string groupName, string packageName, string packageVersion) => 
            await DownloadPackageAsync(GetVirtualPackageDownloadPath(feedName, groupName, packageName, packageVersion));

        public async Task<object> UniversalFeed_DownloadVirtualPackageLatestVersionAsync(string feedName, string groupName, string packageName)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue("latest")
            );

            return await DownloadPackageAsync(GetVirtualPackageDownloadPath(feedName, groupName, packageName), queryParamValues);
        }

        public async Task<FeedMetaData> UniversalFeed_GetFeedMetaDataAsync(string feedName)
        {
            return await GetUniversalFeedApiClient($"/{feedName}/meta")
                .GetJsonAsync<FeedMetaData>();
        }

        public async Task<IEnumerable<Package>> UniversalFeed_SearchPackagesAsync(string feedName, string query, int? count = null)
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
