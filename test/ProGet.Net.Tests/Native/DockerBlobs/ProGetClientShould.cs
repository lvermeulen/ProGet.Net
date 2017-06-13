using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task DockerBlobs_GetBlobsAsync()
        {
            var results = await _client.DockerBlobs_GetBlobsAsync(6);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

