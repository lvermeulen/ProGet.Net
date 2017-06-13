using System;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Packages_GetPackagesAsync()
        {
            var results = await _client.Packages_GetPackagesAsync(1000, 2, DateTime.Today);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

