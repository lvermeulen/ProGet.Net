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
        /// Gets the a complete list of ProGet configuration settings
        /// </summary>
        public async Task<IEnumerable<Configuration>> Configuration_GetConfigurationAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<Configuration>>(nameof(Configuration_GetConfigurationAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the specified ProGet configuration value
        /// </summary>
        public async Task<Configuration> Configuration_GetValueAsync(string key_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(key_Name).Capitalize(), key_Name)
            );

            return await ExecuteNativeApiMethodAsync<Configuration>(nameof(Configuration_GetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets a ProGet configuration value
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Configuration_SetValueAsync(string key_Name, string value_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(key_Name).Capitalize(), key_Name),
                new NamedValue(nameof(value_Text).Capitalize(), value_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Configuration_SetValueAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
