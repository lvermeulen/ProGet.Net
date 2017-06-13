using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task BowerPackages_GetPackagesAsync()
        {
            var results = await _client.BowerPackages_GetPackagesAsync(5);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

