using System;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task NpmFeeds_GetAllPackageVersionsAsync()
        {
            var results = await _client.NpmFeeds_GetAllPackageVersionsAsync(4);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task NpmFeeds_GetConnectorPackageAsync()
        {
            var result = await _client.NpmFeeds_GetConnectorPackageAsync(4, "express", "4.15.3");

            Assert.NotNull(result);
        }

        [Fact]
        public async Task NpmFeeds_GetLatestPackageVersionsAsync()
        {
            var results = await _client.NpmFeeds_GetLatestPackageVersionsAsync(4, DateTime.Today.AddYears(-2));

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

