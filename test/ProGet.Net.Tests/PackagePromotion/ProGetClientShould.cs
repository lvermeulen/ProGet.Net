using System.Threading.Tasks;
using Xunit;

// ReSharper disable CheckNamespace

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        [Theory]
        [InlineData("fromFeed", "toFeed")]
        public async Task PackagePromotion_ListPromotionsAsync(string fromFeed, string toFeed)
        {
            var results = await _client.PackagePromotion_ListPromotionsAsync(fromFeed, toFeed, null, null, null);

            Assert.NotNull(results);
            Assert.NotEmpty(results);
        }
    }
}

