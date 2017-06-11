using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task FeedPackageFilters_GetPackageFiltersAsync()
        {
            var results = await _client.FeedPackageFilters_GetPackageFiltersAsync(2);

            Assert.NotNull(results);
            //Assert.NotEmpty(results);
        }
    }
}

