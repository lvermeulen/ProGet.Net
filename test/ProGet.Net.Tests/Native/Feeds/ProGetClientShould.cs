using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Feeds_GetFeedAsync()
        {
            var result = await _client.Feeds_GetFeedAsync(1, null);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Feeds_GetFeedConnectorsAsync()
        {
            var results = await _client.Feeds_GetFeedConnectorsAsync(2, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Feeds_GetFeedsAsync()
        {
            var results = await _client.Feeds_GetFeedsAsync(true);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Feeds_GetLicenseUrlsAsync()
        {
            var results = await _client.Feeds_GetLicenseUrlsAsync(2);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Feeds_GetMavenFeedAsync()
        {
            var result = await _client.Feeds_GetMavenFeedAsync(3, null);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Feeds_GetNpmFeedAsync()
        {
            var result = await _client.Feeds_GetNpmFeedAsync(4, null);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Feeds_GetNuGetFeedAsync()
        {
            var result = await _client.Feeds_GetNuGetFeedAsync(2, null);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Feeds_GetSyncFeedsAsync()
        {
            var result = await _client.Feeds_GetSyncFeedsAsync();

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Feeds_GetSyncSettingsAsync()
        {
            var result = await _client.Feeds_GetSyncSettingsAsync(2);

            Assert.NotNull(result);
        }
    }
}

