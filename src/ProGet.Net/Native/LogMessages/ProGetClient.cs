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
        /// Deletes one or all messages from the error log
        /// </summary>
        public async Task<bool> LogMessages_DeleteMessagesAsync(
            int? logMessage_Id,
            string category_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(logMessage_Id).Capitalize(), logMessage_Id),
                new NamedValue(nameof(category_Name).Capitalize(), category_Name)
            );

            return await ExecuteNativeApiMethodAsync(nameof(LogMessages_DeleteMessagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a specified message from the error log
        /// </summary>
        public async Task<LogMessage> LogMessages_GetMessageAsync(int logMessage_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(logMessage_Id).Capitalize(), logMessage_Id)
            );

            return await ExecuteNativeApiMethodAsync<LogMessage>(nameof(LogMessages_GetMessageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the messages from the error log that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<LogMessage>> LogMessages_GetMessagesAsync(
            int row_Count,
            bool includeReadMessages_Indicator,
            string category_Name,
            int message_Level)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(row_Count).Capitalize(), row_Count),
                new NamedValue(nameof(includeReadMessages_Indicator).Capitalize(), includeReadMessages_Indicator.ToYnIndicator()),
                new NamedValue(nameof(category_Name).Capitalize(), category_Name),
                new NamedValue(nameof(message_Level).Capitalize(), message_Level)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<LogMessage>>(nameof(LogMessages_GetMessagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
