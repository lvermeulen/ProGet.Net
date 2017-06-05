using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Fact]
        public async Task Users_GetGroupsAsync()
        {
            var results = await _client.Users_GetGroupsAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Theory]
        [InlineData("Admin")]
        public async Task Users_GetUserAsync(string userName)
        {
            var result = await _client.Users_GetUserAsync(userName);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task Users_GetUsersAsync()
        {
            var result = await _client.Users_GetUsersAsync();

            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Administrators")]
        public async Task Users_GetUsersInGroupAsync(string groupName)
        {
            var results = await _client.Users_GetUsersInGroupAsync(groupName);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

