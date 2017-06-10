using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Executions_GetExecutionAsync()
        {
            var result = await _client.Executions_GetExecutionAsync(3).ConfigureAwait(false);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Executions_GetFeedSyncExecutionsAsync()
        {
            var results = await _client.Executions_GetFeedSyncExecutionsAsync(1, 1000);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

