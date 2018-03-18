using System;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task NuGetPackagesV2_GetLatestAsync()
        {
            var results = await _client.NuGetPackagesV2_GetLatestAsync(7, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackagesV2_GetLatestStableAsync()
        {
            var results = await _client.NuGetPackagesV2_GetLatestStableAsync(7, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackagesV2_GetPackageAsync()
        {
            var results = await _client.NuGetPackagesV2_GetPackageAsync(7, "Akka.Streams.TestKit", null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackagesV2_GetPackagesAsync()
        {
            var results = await _client.NuGetPackagesV2_GetPackagesAsync(7, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NuGetPackageSymbolsV2_GetSymbolsAsync()
        {
            string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes("0x3BAB0159A4AF9A41B962D610419106FC"));
            var results = await _client.NuGetPackageSymbolsV2_GetSymbolsAsync(7, base64, "Antlr3.Runtime.pdb", 0);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

