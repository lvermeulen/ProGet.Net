using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task wLogMessages_GetMessagesAsync()
        {
            var results = await _client.LogMessages_GetMessagesAsync(1000, true, null, 0);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

