using System;
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
        /// Creates a new npm package or updates an existing one
        /// </summary>
        public async Task<bool> NpmPackages_CreateOrUpdatePackageAsync(
            int feed_Id,
            string package_Name,
            string scope_Name,
            string version_Text,
            byte[] packageJson_Bytes,
            DateTime published_Date,
            string tag_Name,
            byte[] packageHash_Bytes,
            bool cached_Indicator,
            long package_Size)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text),
                new NamedValue(nameof(packageJson_Bytes).Capitalize(), packageJson_Bytes),
                new NamedValue(nameof(published_Date).Capitalize(), published_Date.ToJsonDateTime()),
                new NamedValue(nameof(tag_Name).Capitalize(), tag_Name),
                new NamedValue(nameof(packageHash_Bytes).Capitalize(), packageHash_Bytes),
                new NamedValue(nameof(cached_Indicator).Capitalize(), cached_Indicator.ToYnIndicator()),
                new NamedValue(nameof(package_Size).Capitalize(), package_Size)
            );

            return await ExecuteNativeApiMethodAsync(nameof(NpmPackages_CreateOrUpdatePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a package in an npm feed
        /// </summary>
        public async Task<bool> NpmPackages_DeletePackageAsync(
            int feed_Id,
            string package_Name,
            string scope_Name,
            string version_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(NpmPackages_DeletePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a package and its versions and tags
        /// </summary>
        public async Task<NpmPackagesVersionsTags> NpmPackages_GetPackageAsync(
            int feed_Id,
            string package_Name,
            string scope_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(scope_Name).Capitalize(), scope_Name)
            );

            return await ExecuteNativeApiMethodAsync<NpmPackagesVersionsTags>(nameof(NpmPackages_GetPackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
