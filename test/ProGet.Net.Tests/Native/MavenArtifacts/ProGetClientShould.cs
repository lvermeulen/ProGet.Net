using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task MavenArtifacts_GetArtifactFilesAsync()
        {
            var results = await _client.MavenArtifacts_GetArtifactFilesAsync(3, "abbot", "abbot", "1.4.0", null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task MavenArtifacts_GetArtifactsAsync()
        {
            var results = await _client.MavenArtifacts_GetArtifactsAsync(3, "abbot", "abbot");

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task MavenArtifacts_GetArtifactVersionsAsync()
        {
            var results = await _client.MavenArtifacts_GetArtifactVersionsAsync(3, "abbot", "abbot");

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

