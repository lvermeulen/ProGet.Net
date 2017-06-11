using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task FeedRetentionRules_GetRulesAsync()
        {
            var results = await _client.FeedRetentionRules_GetRulesAsync(2);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

