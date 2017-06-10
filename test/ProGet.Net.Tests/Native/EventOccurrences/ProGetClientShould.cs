using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task EventOccurrences_GetOccurrencesAsync()
        {
            var results = await _client.EventOccurrences_GetOccurrencesAsync(2);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

