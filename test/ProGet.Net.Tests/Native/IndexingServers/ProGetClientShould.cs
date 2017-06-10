using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task IndexingServers_GetServersAsync()
        {
            var results = await _client.IndexingServers_GetServersAsync();

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }
    }
}

