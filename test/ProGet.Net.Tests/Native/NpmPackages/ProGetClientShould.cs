using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task NpmPackages_GetPackageAsync()
        {
            var result = await _client.NpmPackages_GetPackageAsync(4, "express", "latest");

            Assert.NotNull(result);
        }
    }
}

