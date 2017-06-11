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
        /// Creates a new feed retention rule or updates an existing one
        /// </summary>
        /// <returns>Sequence_Number</returns>
        public async Task<int> FeedRetentionRules_CreateOrUpdateRuleAsync(
            int feed_Id,
            bool deletePrereleaseVersions_Indicator,
            bool deleteCached_Indicator,
            int keepVersions_Count,
            int keepUsedWithin_Days,
            string deletePackageIds_Csv,
            string keepPackageIds_Csv,
            long sizeTrigger_KBytes,
            bool sizeExclusive_Indicator,
            int sequence_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(deletePrereleaseVersions_Indicator).Capitalize(), deletePrereleaseVersions_Indicator.ToYnIndicator()),
                new NamedValue(nameof(deleteCached_Indicator).Capitalize(), deleteCached_Indicator.ToYnIndicator()),
                new NamedValue(nameof(keepVersions_Count).Capitalize(), keepVersions_Count),
                new NamedValue(nameof(keepUsedWithin_Days).Capitalize(), keepUsedWithin_Days),
                new NamedValue(nameof(deletePackageIds_Csv).Capitalize(), deletePackageIds_Csv),
                new NamedValue(nameof(keepPackageIds_Csv).Capitalize(), keepPackageIds_Csv),
                new NamedValue(nameof(sizeTrigger_KBytes).Capitalize(), sizeTrigger_KBytes),
                new NamedValue(nameof(sizeExclusive_Indicator).Capitalize(), sizeExclusive_Indicator.ToYnIndicator()),
                new NamedValue(nameof(sequence_Number).Capitalize(), sequence_Number)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(FeedRetentionRules_CreateOrUpdateRuleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a feed retention rule
        /// </summary>
        public async Task<bool> FeedRetentionRules_DeleteRuleAsync(
            int feed_Id,
            int Sequence_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(Sequence_Number).Capitalize(), Sequence_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(FeedRetentionRules_DeleteRuleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the retention rules for a feed
        /// </summary>
        public async Task<IEnumerable<FeedRetentionRuleExtended>> FeedRetentionRules_GetRulesAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<FeedRetentionRuleExtended>>(nameof(FeedRetentionRules_GetRulesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Resequences a feed retention rule
        /// </summary>
        public async Task<bool> FeedRetentionRules_ResequenceRuleAsync(
            int feed_Id,
            int sequence_Number,
            int new_Sequence_Number)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(sequence_Number).Capitalize(), sequence_Number),
                new NamedValue(nameof(new_Sequence_Number).Capitalize(), new_Sequence_Number)
            );

            return await ExecuteNativeApiMethodAsync(nameof(FeedRetentionRules_ResequenceRuleAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
