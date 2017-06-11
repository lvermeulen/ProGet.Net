using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task FeedAdapters_GetFeedAdaptersAsync()
        {
            var results = await _client.FeedAdapters_GetFeedAdaptersAsync(2);

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }
    }
}

