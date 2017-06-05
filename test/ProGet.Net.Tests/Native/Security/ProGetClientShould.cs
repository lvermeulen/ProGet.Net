using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Security_GetPrivilegesAsync()
        {
            var results = await _client.Security_GetPrivilegesAsync(1, "U");

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task Security_GetRolesAsync()
        {
            var result = await _client.Security_GetRolesAsync();

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Security_GetTasksAsync()
        {
            var results = await _client.Security_GetTasksAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

