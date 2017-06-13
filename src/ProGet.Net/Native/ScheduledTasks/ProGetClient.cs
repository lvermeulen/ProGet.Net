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
        /// Gets some or all of the executions of a scheduled task
        /// </summary>
        public async Task<IEnumerable<Executions>> ScheduledTasks_GetExecutionsAsync(
            int scheduledTask_Id,
            int max_Results)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scheduledTask_Id).Capitalize(), scheduledTask_Id),
                new NamedValue(nameof(max_Results).Capitalize(), max_Results)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Executions>>(nameof(ScheduledTasks_GetExecutionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the scheduled tasks, optionally filtered by feed
        /// </summary>
        public async Task<IEnumerable<ScheduledTasksExtended>> ScheduledTasks_GetScheduledTasksAsync(int? feed_Id = null)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<ScheduledTasksExtended>>(nameof(ScheduledTasks_GetScheduledTasksAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the configuration of a scheduled task
        /// </summary>
        public async Task<bool> ScheduledTasks_UpdateScheduledTaskAsync(
            int scheduledTask_Id,
            int frequency_Hours,
            int startTimeOfDay_Minutes,
            int endTimeOfDay_Minutes,
            bool active_Indicator,
            bool runImmediately_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(scheduledTask_Id).Capitalize(), scheduledTask_Id),
                new NamedValue(nameof(frequency_Hours).Capitalize(), frequency_Hours),
                new NamedValue(nameof(startTimeOfDay_Minutes).Capitalize(), startTimeOfDay_Minutes),
                new NamedValue(nameof(endTimeOfDay_Minutes).Capitalize(), endTimeOfDay_Minutes),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(runImmediately_Indicator).Capitalize(), runImmediately_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(ScheduledTasks_UpdateScheduledTaskAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
