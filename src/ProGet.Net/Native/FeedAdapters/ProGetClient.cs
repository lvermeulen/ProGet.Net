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
        /// Creates a new feed adapter or updates an existing one
        /// </summary>
        public async Task<bool> FeedAdapters_CreateOrUpdateFeedAdapterAsync(
            int feed_Id,
            int feedAdapter_Sequence,
            string feedAdapter_Name,
            string feedAdapterType_Code,
            string feedAdapter_Configuration)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feedAdapter_Sequence).Capitalize(), feedAdapter_Sequence),
                new NamedValue(nameof(feedAdapter_Name).Capitalize(), feedAdapter_Name),
                new NamedValue(nameof(feedAdapterType_Code).Capitalize(), feedAdapterType_Code),
                new NamedValue(nameof(feedAdapter_Configuration).Capitalize(), feedAdapter_Configuration)
            );

            return await ExecuteNativeApiMethodAsync(nameof(FeedAdapters_CreateOrUpdateFeedAdapterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a feed adapter
        /// </summary>
        public async Task<bool> FeedAdapters_DeleteFeedAdapterAsync(
            int feed_Id,
            int feedAdapter_Sequence)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feedAdapter_Sequence).Capitalize(), feedAdapter_Sequence)
            );

            return await ExecuteNativeApiMethodAsync(nameof(FeedAdapters_DeleteFeedAdapterAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of adapters associated with the specified feed
        /// </summary>
        public async Task<IEnumerable<FeedAdapter>> FeedAdapters_GetFeedAdaptersAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<FeedAdapter>>(nameof(FeedAdapters_GetFeedAdaptersAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
