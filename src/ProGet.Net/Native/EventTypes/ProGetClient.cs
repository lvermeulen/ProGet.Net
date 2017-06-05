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
        /// Gets all of the event types
        /// </summary>
        public async Task<IEnumerable<EventType>> EventTypes_GetEventTypesAsync() => 
            await ExecuteNativeApiMethodAsync<IEnumerable<EventType>>(nameof(EventTypes_GetEventTypesAsync).WithoutAsyncSuffix()).ConfigureAwait(false);
    }
}
