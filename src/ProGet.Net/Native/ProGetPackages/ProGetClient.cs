using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProGet.Net.Common;
using ProGet.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        /// <summary>
        /// Creates a new ProGet package or updates an existing one
        /// </summary>
        public async Task<bool> ProGetPackages_CreateOrUpdatePackageAsync(
            int feed_Id,
            string group_Name,
            string package_Name,
            string version_Text,
            byte[] packageMetadata_Bytes,
            DateTime published_Date,
            byte[] packageHash_Bytes,
            bool cached_Indicator,
            long package_Size,
            string title_Text,
            string description_Text,
            string iconUrl_Text,
            string latestVersion_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text),
                new NamedValue(nameof(packageMetadata_Bytes).Capitalize(), packageMetadata_Bytes),
                new NamedValue(nameof(published_Date).Capitalize(), published_Date),
                new NamedValue(nameof(packageHash_Bytes).Capitalize(), packageHash_Bytes),
                new NamedValue(nameof(cached_Indicator).Capitalize(), cached_Indicator.ToYnIndicator()),
                new NamedValue(nameof(package_Size).Capitalize(), package_Size),
                new NamedValue(nameof(title_Text).Capitalize(), title_Text),
                new NamedValue(nameof(description_Text).Capitalize(), description_Text),
                new NamedValue(nameof(iconUrl_Text).Capitalize(), iconUrl_Text),
                new NamedValue(nameof(latestVersion_Text).Capitalize(), latestVersion_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(ProGetPackages_CreateOrUpdatePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the number of packages in a ProGet feed
        /// </summary>
        /// <returns>Package_Count</returns>
        public async Task<int> ProGetPackages_GetPackageCountAsync(
            int feed_Id,
            bool includeVersions_Indicator,
            int package_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(includeVersions_Indicator).Capitalize(), includeVersions_Indicator.ToYnIndicator()),
                new NamedValue(nameof(package_Count).Capitalize(), package_Count)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(ProGetPackages_GetPackageCountAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the packages in a ProGet feed
        /// </summary>
        public async Task<IEnumerable<ProGetPackage>> ProGetPackages_GetPackagesAsync(
            int feed_Id,
            string group_Name,
            string package_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ProGetPackage>>(nameof(ProGetPackages_GetPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the package versions in a ProGet feed
        /// </summary>
        public async Task<IEnumerable<ProGetPackageVersionExtended>> ProGetPackages_GetPackageVersionsAsync(
            int feed_Id,
            string group_Name,
            string package_Name,
            string version_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(group_Name).Capitalize(), group_Name),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ProGetPackageVersionExtended>>(nameof(ProGetPackages_GetPackageVersionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the packages in a ProGet feed that have been downloaded the most
        /// </summary>
        public async Task<IEnumerable<ProGetPackage>> ProGetPackages_GetPopularPackagesAsync(
            int feed_Id,
            int max_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(max_Count).Capitalize(), max_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ProGetPackage>>(nameof(ProGetPackages_GetPopularPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Searhes the packages in a ProGet feed
        /// </summary>
        public async Task<IEnumerable<ProGetPackage>> ProGetPackages_SearchPackagesAsync(
            int feed_Id,
            string search_Term)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(search_Term).Capitalize(), search_Term)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ProGetPackage>>(nameof(ProGetPackages_SearchPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
