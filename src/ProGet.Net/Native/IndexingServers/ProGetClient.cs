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
        /// Deletes an indexing server
        /// </summary>
        public async Task<bool> IndexingServers_DeleteServerAsync(string server_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(server_Name).Capitalize(), server_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(IndexingServers_DeleteServerAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the indexing servers registered with ProGet
        /// </summary>
        public async Task<IEnumerable<IndexingServer>> IndexingServers_GetServersAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<IndexingServer>>(nameof(IndexingServers_GetServersAsync).WithoutAsyncSuffix()).ConfigureAwait(false);
    }
}
