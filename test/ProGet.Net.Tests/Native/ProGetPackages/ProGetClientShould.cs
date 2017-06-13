using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task ProGetPackages_GetPackageCountAsync()
        {
            var result = await _client.ProGetPackages_GetPackageCountAsync(1, true, 1000);

            Assert.True(result >= 0);
        }

        [Fact]
        public async Task ProGetPackages_GetPackagesAsync()
        {
            var results = await _client.ProGetPackages_GetPackagesAsync(2, null, null);

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ProGetPackages_GetPackageVersionsAsync()
        {
            var results = await _client.ProGetPackages_GetPackageVersionsAsync(2, null, null, null);

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ProGetPackages_GetPopularPackagesAsync()
        {
            var results = await _client.ProGetPackages_GetPopularPackagesAsync(2, 1000);

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ProGetPackages_SearchPackagesAsync()
        {
            var results = await _client.ProGetPackages_SearchPackagesAsync(2, "antlr");

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }
    }
}

