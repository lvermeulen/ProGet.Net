using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Configuration_GetConfigurationAsync()
        {
            var results = await _client.Configuration_GetConfigurationAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

