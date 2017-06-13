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
        /// Creates a new Bower package in the system, or updates an existing one
        /// </summary>
        public async Task<bool> BowerPackages_CreateOrUpdatePackageAsync(
            int feed_Id,
            string package_Name,
            string repository_Url)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name),
                new NamedValue(nameof(repository_Url).Capitalize(), repository_Url)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BowerPackages_CreateOrUpdatePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a Bower package
        /// </summary>
        public async Task<bool> BowerPackages_DeletePackageAsync(
            int feed_Id,
            string package_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(BowerPackages_DeletePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified package in a Bower feed
        /// </summary>
        public async Task<BowerPackage> BowerPackages_GetPackageAsync(
            int feed_Id,
            string package_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Name).Capitalize(), package_Name)
            );

            return await ExecuteNativeApiMethodAsync<BowerPackage>(nameof(BowerPackages_GetPackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the packages in a Bower feed
        /// </summary>
        public async Task<IEnumerable<BowerPackage>> BowerPackages_GetPackagesAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<BowerPackage>>(nameof(BowerPackages_GetPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
