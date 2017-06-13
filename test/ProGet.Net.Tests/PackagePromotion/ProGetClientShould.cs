using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Theory]
        [InlineData("TestUniversal")]
        public async Task UniversalFeed_ListPackagesAsync(string feedName)
        {
            var results = await _client.UniversalFeed_ListPackagesAsync(feedName);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

