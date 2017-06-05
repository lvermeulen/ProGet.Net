using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Theory]
        [InlineData(4)]
        public async Task ScheduledTasks_GetExecutionsAsync(int scheduledTaskId)
        {
            var results = await _client.ScheduledTasks_GetExecutionsAsync(scheduledTaskId, 1000);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }

        [Fact]
        public async Task ScheduledTasks_GetScheduledTasksAsync()
        {
            var results = await _client.ScheduledTasks_GetScheduledTasksAsync();

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

