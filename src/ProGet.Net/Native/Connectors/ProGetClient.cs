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
        /// Creates a new connector in the system, or updates an existing one
        /// </summary>
        /// <returns>Coonector_Id</returns>
        public async Task<int> Connectors_CreateOrUpdateConnectorAsync(
            string feedType_Name,
            string connector_Name,
            string connector_Url,
            string filter_Csv,
            string user_Name,
            byte[] password_Bytes,
            int timeout_Period,
            int connector_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feedType_Name).Capitalize(), feedType_Name),
                new NamedValue(nameof(connector_Name).Capitalize(), connector_Name),
                new NamedValue(nameof(connector_Url).Capitalize(), connector_Url),
                new NamedValue(nameof(filter_Csv).Capitalize(), filter_Csv),
                new NamedValue(nameof(user_Name).Capitalize(), user_Name),
                new NamedValue(nameof(password_Bytes).Capitalize(), password_Bytes),
                new NamedValue(nameof(timeout_Period).Capitalize(), timeout_Period),
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Connectors_CreateOrUpdateConnectorAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes a connector
        /// </summary>
        public async Task<bool> Connectors_DeleteConnectorAsync(int connector_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Connectors_DeleteConnectorAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified connector
        /// </summary>
        public async Task<Connector> Connectors_GetConnectorAsync(int connector_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id)
            );

            return await ExecuteNativeApiMethodAsync<Connector>(nameof(Connectors_GetConnectorAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the connectors
        /// </summary>
        public async Task<IEnumerable<Connector>> Connectors_GetConnectorsAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Connector>>(nameof(Connectors_GetConnectorsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
