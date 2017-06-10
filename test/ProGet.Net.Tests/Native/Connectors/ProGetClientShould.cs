using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Connectors_GetConnectorsAsync()
        {
            var results = await _client.Connectors_GetConnectorsAsync(2);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

