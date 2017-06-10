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
        /// Permanently deletes all data for the specified execution
        /// </summary>
        public async Task<bool> Executions_DeleteExecutionAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Executions_DeleteExecutionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about an execution as well as all of the log entries for it
        /// </summary>
        public async Task<ExecutionsExecutionLogEntries> Executions_GetExecutionAsync(int execution_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(execution_Id).Capitalize(), execution_Id)
            );

            return await ExecuteNativeApiMethodAsync<ExecutionsExecutionLogEntries>(nameof(Executions_GetExecutionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets some or all of the replication executions for a feed
        /// </summary>
        public async Task<IEnumerable<Execution>> Executions_GetFeedSyncExecutionsAsync(
            int feed_Id,
            int max_Results)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(max_Results).Capitalize(), max_Results)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Execution>>(nameof(Executions_GetFeedSyncExecutionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
