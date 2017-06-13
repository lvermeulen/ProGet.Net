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
        /// Gets all versions of all of the packages in an npm feed
        /// </summary>
        public async Task<IEnumerable<NpmPackageAllVersions>> NpmFeeds_GetAllPackageVersionsAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NpmPackageAllVersions>>(nameof(NpmFeeds_GetAllPackageVersionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a package from a feed's connector with the specified name and version
        /// </summary>
        public async Task<NpmConnectorPackage> NpmFeeds_GetConnectorPackageAsync(
            int feed_Id,
            string package_Name,
            string package_Version)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(package_Version).Capitalize(), package_Version)
            );

            return await ExecuteNativeApiMethodAsync<NpmConnectorPackage>(nameof(NpmFeeds_GetConnectorPackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the latest versions of packages in a feed
        /// </summary>
        public async Task<IEnumerable<NpmPackageLatest>> NpmFeeds_GetLatestPackageVersionsAsync(
            int feed_Id,
            DateTime since_Date)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(since_Date).Capitalize(), since_Date.ToJsonDateTime())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NpmPackageLatest>>(nameof(NpmFeeds_GetLatestPackageVersionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the version which a package tag points to
        /// </summary>
        public async Task<bool> NpmFeeds_SetTagVersionAsync(
            int feed_Id,
            string package_Name,
            string scope_Name,
            string tag_Name,
            string tag_Version)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name),
                new NamedValue(nameof(tag_Name).Capitalize(), tag_Name),
                new NamedValue(nameof(tag_Version).Capitalize(), tag_Version)
            );

            return await ExecuteNativeApiMethodAsync(nameof(NpmFeeds_SetTagVersionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
