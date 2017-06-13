using System;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task NpmConnectors_GetPackagesAsync()
        {
            var results = await _client.NpmConnectors_GetPackagesAsync(2, "express", "", DateTime.Today.AddYears(-2), 10);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

