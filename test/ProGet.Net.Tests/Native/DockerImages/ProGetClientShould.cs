using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task DockerImages_GetImagesAsync()
        {
            var results = await _client.DockerImages_GetImagesAsync(6, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task DockerImages_GetRepositoriesAsync()
        {
            var results = await _client.DockerImages_GetRepositoriesAsync(6, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task DockerImages_GetTagsAsync()
        {
            var results = await _client.DockerImages_GetTagsAsync(6, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

