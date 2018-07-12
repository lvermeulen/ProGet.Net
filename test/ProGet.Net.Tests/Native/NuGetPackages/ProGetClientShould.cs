using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task NuGetPackages_GetLatestAsync()
        {
            var results = await _client.NuGetPackages_GetLatestAsync(2, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackages_GetLatestStableAsync()
        {
            var results = await _client.NuGetPackages_GetLatestStableAsync(2, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackages_GetPackageAsync()
        {
            var result = await _client.NuGetPackages_GetPackageAsync(2, "Antlr", null);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task NuGetPackages_GetPackageCountAsync()
        {
            int result = await _client.NuGetPackages_GetPackageCountAsync(2, "AspNet.ScriptManager.bootstrap", 1000);

            Assert.True(result >= 0);
        }

        [Fact]
        public async Task NuGetPackages_GetPackagesAsync()
        {
            var results = await _client.NuGetPackages_GetPackagesAsync(2, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

