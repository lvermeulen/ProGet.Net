using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Dashboards_GetDashboardInfoAsync()
        {
            var result = await _client.Dashboards_GetDashboardInfoAsync(1000, true);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Dashboards_GetLargestPackagesAsync()
        {
            var results = await _client.Dashboards_GetLargestPackagesAsync(2);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

