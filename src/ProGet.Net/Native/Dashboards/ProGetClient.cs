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
        /// Gets data relevant to the ProGet homepage
        /// </summary>
        /// //TODO: returns DashboardPackages_Latest, DashboardFeeds
        public async Task<DashboardPackagesLatest> Dashboards_GetDashboardInfoAsync(
            int packages_Count,
            bool includeInactive_Indicator
        )
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(packages_Count).Capitalize(), packages_Count),
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<DashboardPackagesLatest>(nameof(Dashboards_GetDashboardInfoAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the largest packages in a feed
        /// </summary>
        public async Task<IEnumerable<DashboardPackagesLargest>> Dashboards_GetLargestPackagesAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DashboardPackagesLargest>>(nameof(Dashboards_GetLargestPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
