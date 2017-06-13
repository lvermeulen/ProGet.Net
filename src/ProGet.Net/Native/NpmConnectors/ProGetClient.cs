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
        /// Gets the npm connector packages which match the specified criteria
        /// </summary>
        public async Task<IEnumerable<NpmConnectorPackage>> NpmConnectors_GetPackagesAsync(
            int connector_Id,
            string includeName_Csv,
            string excludeName_Csv,
            DateTime modifiedAfter_Date,
            int maxResults_Count)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id),
                new NamedValue(nameof(includeName_Csv).Capitalize(), includeName_Csv),
                new NamedValue(nameof(excludeName_Csv).Capitalize(), excludeName_Csv),
                new NamedValue(nameof(modifiedAfter_Date).Capitalize(), modifiedAfter_Date.ToJsonDateTime()),
                new NamedValue(nameof(maxResults_Count).Capitalize(), maxResults_Count)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NpmConnectorPackage>>(nameof(NpmConnectors_GetPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
