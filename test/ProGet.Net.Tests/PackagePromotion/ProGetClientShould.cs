using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Theory]
        [InlineData("TestUniversal")]
        public async Task ListUniversalFeedPackagesAsync(string feedName)
        {
            var results = await _client.ListUniversalFeedPackagesAsync(feedName);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

