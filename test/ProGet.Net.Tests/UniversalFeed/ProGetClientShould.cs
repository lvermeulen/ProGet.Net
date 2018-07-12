using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Theory]
        [InlineData("Tobania-Universal")]
        public async Task UniversalFeed_ListPackagesAsync(string feedName)
        {
            var results = await _client.UniversalFeed_ListPackagesAsync(feedName);

            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("Tobania-Universal")]
        public async Task UniversalFeed_GetFeedMetaDataAsync(string feedName)
        {
            var result = await _client.UniversalFeed_GetFeedMetaDataAsync(feedName);

            Assert.NotNull(result);
        }
    }
}

