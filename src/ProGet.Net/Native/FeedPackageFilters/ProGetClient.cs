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
        /// Creates a new feed package filter or updates an existing one
        /// </summary>
        /// <returns>Sequence_Number</returns>
        public async Task<int> FeedPackageFilters_CreateOrUpdatePackageFilterAsync(
            int feed_Id,
            string packageFilter_Name,
            string packageFilter_Configuration,
            int sequence_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(packageFilter_Name).Capitalize(), packageFilter_Name),
                new NamedValue(nameof(packageFilter_Configuration).Capitalize(), packageFilter_Configuration),
                new NamedValue(nameof(sequence_Number).Capitalize(), sequence_Number)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(FeedPackageFilters_CreateOrUpdatePackageFilterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a feed package filter
        /// </summary>
        public async Task<bool> FeedPackageFilters_DeletePackageFilterAsync(
            int feed_Id,
            int sequence_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(sequence_Number).Capitalize(), sequence_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(FeedPackageFilters_DeletePackageFilterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns all of the package filters for a feed
        /// </summary>
        public async Task<IEnumerable<FeedPackageFilter>> FeedPackageFilters_GetPackageFiltersAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<FeedPackageFilter>>(nameof(FeedPackageFilters_GetPackageFiltersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
