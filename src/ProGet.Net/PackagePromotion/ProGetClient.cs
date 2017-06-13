using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using ProGet.Net.Common;
using ProGet.Net.PackagePromotion.Models;

// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        private IFlurlClient GetPackagePromotionApiClient(string path, object queryParamValues = null) => GetApiClient("/api/promotions")
            .AppendPathSegment(path)
            .SetQueryParams(queryParamValues, Flurl.NullValueHandling.NameOnly)
            .AllowAnyHttpStatus();

        public async Task<IEnumerable<Promotion>> PackagePromotion_ListPromotionsAsync(string fromFeed, string toFeed, string groupName, string packageName, string version)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(fromFeed), fromFeed),
                new NamedValue(nameof(toFeed), toFeed),
                new NamedValue(nameof(groupName), groupName),
                new NamedValue(nameof(packageName), packageName),
                new NamedValue(nameof(version), version)
            );

            return await GetPackagePromotionApiClient("list", queryParamValues)
                .GetJsonAsync<IEnumerable<Promotion>>();
        }

        public async Task<bool> PackagePromotion_PromotePackageAsync(PackagePromotionContents packagePromotion)
        {
            var response = await GetPackagePromotionApiClient("promote")
                .PostJsonAsync(packagePromotion);

            return response.IsSuccessStatusCode;
        }
    }
}
