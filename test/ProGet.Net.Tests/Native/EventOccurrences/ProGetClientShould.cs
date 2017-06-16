using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task EventOccurrences_GetOccurrenceAsync()
        {
            var result = await _client.EventOccurrences_GetOccurrenceAsync(1);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task EventOccurrences_GetOccurrencesAsync()
        {
            var results = await _client.EventOccurrences_GetOccurrencesAsync(null, null, 1000);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task EventOccurrences_GetUsersAsync()
        {
            var results = await _client.EventOccurrences_GetUsersAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

