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
        /// Gets a list of combined packages filtering by the specified criteria
        /// </summary>
        public async Task<IEnumerable<PackagesCombined>> Packages_GetPackagesAsync(
            int packages_Count,
            int feed_Id,
            DateTime publishedBefore_Date)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(packages_Count).Capitalize(), packages_Count),
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(publishedBefore_Date).Capitalize(), publishedBefore_Date) //TODO: verify DateTime
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<PackagesCombined>>(nameof(Packages_GetPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
