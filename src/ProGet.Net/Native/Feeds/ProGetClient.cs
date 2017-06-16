using System.Collections.Generic;
using System.Threading.Tasks;
using ProGet.Net.Common;
using ProGet.Net.Native.Models;

// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace

namespace ProGet.Net
{
    public partial class ProGetClient
    {
        /// <summary>
        /// Associates a connector with a feed
        /// </summary>
        public async Task<bool> Feeds_AddFeedConnectorAsync(
            int feed_Id,
            int connector_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_AddFeedConnectorAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new Bower feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateBowerFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateBowerFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new Docker feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateDockerFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateDockerFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new Maven feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateMavenFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateMavenFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new npm feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateNpmFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator,
            string dropPath_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator()),
                new NamedValue(nameof(dropPath_Text).Capitalize(), dropPath_Text)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateNpmFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new NuGet feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateNuGetFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator,
            string feedPathOverride_Text,
            string aPIKey_Text,
            bool symbolServerEnabled_Indicator,
            string packageStoreConfiguration_Xml,
            string feedType_Name,
            bool stripSymbolFiles_Indicator,
            string dropPath_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator()),
                new NamedValue(nameof(feedPathOverride_Text).Capitalize(), feedPathOverride_Text),
                new NamedValue(nameof(aPIKey_Text).Capitalize(), aPIKey_Text),
                new NamedValue(nameof(symbolServerEnabled_Indicator).Capitalize(), symbolServerEnabled_Indicator.ToYnIndicator()),
                new NamedValue(nameof(packageStoreConfiguration_Xml).Capitalize(), packageStoreConfiguration_Xml),
                new NamedValue(nameof(feedType_Name).Capitalize(), feedType_Name),
                new NamedValue(nameof(stripSymbolFiles_Indicator).Capitalize(), stripSymbolFiles_Indicator.ToYnIndicator()),
                new NamedValue(nameof(dropPath_Text).Capitalize(), dropPath_Text)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateNuGetFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates a new Universal feed or updates an existing one
        /// </summary>
        /// <returns>Feed_Id</returns>
        public async Task<int> Feeds_CreateOrUpdateProGetFeedAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator,
            string dropPath_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator()),
                new NamedValue(nameof(dropPath_Text).Capitalize(), dropPath_Text)
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(Feeds_CreateOrUpdateProGetFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified feed
        /// </summary>
        public async Task<bool> Feeds_DeleteFeedAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_DeleteFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Dissociates a connector with a feed
        /// </summary>
        public async Task<bool> Feeds_DeleteFeedConnectorAsync(
            int feed_Id,
            int connector_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(connector_Id).Capitalize(), connector_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_DeleteFeedConnectorAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes any sync settings for a feed
        /// </summary>
        public async Task<bool> Feeds_DeleteSyncSettingsAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_DeleteSyncSettingsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of a feed by either name or ID
        /// </summary>
        public async Task<Feed> Feeds_GetFeedAsync(
            int feed_Id,
            string feed_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name)
            );

            return await ExecuteNativeApiMethodAsync<Feed>(nameof(Feeds_GetFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the connectors for a feed
        /// </summary>
        public async Task<IEnumerable<FeedConnectorExtended>> Feeds_GetFeedConnectorsAsync(
            int feed_Id,
            string feed_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<FeedConnectorExtended>>(nameof(Feeds_GetFeedConnectorsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the feeds
        /// </summary>
        public async Task<IEnumerable<Feed>> Feeds_GetFeedsAsync(bool includeInactive_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(includeInactive_Indicator).Capitalize(), includeInactive_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<Feed>>(nameof(Feeds_GetFeedsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of a Maven feed using either an ID or a name
        /// </summary>
        public async Task<FeedsFeedConnectorsExtended> Feeds_GetMavenFeedAsync(
            int feed_Id,
            string feed_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name)
            );

            return await ExecuteNativeApiMethodAsync<FeedsFeedConnectorsExtended>(nameof(Feeds_GetMavenFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an npm feed using either an ID or a name
        /// </summary>
        public async Task<FeedsFeedConnectorsExtended> Feeds_GetNpmFeedAsync(
            int feed_Id,
            string feed_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name)
            );

            return await ExecuteNativeApiMethodAsync<FeedsFeedConnectorsExtended>(nameof(Feeds_GetNpmFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }


        /// <summary>
        /// Gets the details of a NuGet feed using either an ID or a name
        /// </summary>
        public async Task<NuGetFeedsExtendedFeedConnectorsExtendedFeedLIcenseUrls> Feeds_GetNuGetFeedAsync(
            int feed_Id,
            string feed_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name)
            );

            return await ExecuteNativeApiMethodAsync<NuGetFeedsExtendedFeedConnectorsExtendedFeedLIcenseUrls>(nameof(Feeds_GetNuGetFeedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the sync feeds
        /// </summary>
        public async Task<NuGetSyncFeedsNuGetFeedsExtended> Feeds_GetSyncFeedsAsync() => 
            await ExecuteNativeApiMethodAsync<NuGetSyncFeedsNuGetFeedsExtended>(nameof(Feeds_GetSyncFeedsAsync).WithoutAsyncSuffix()).ConfigureAwait(false);

        /// <summary>
        /// Gets the settings for a sync feed
        /// </summary>
        public async Task<NuGetSyncFeed> Feeds_GetSyncSettingsAsync(int feed_Id)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id)
            );

            return await ExecuteNativeApiMethodAsync<NuGetSyncFeed>(nameof(Feeds_GetSyncSettingsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets one or more properties on a feed of any type
        /// </summary>
        public async Task<bool> Feeds_SetFeedPropertyAsync(
            int feed_Id,
            string feed_Name,
            string feed_Description,
            bool active_Indicator,
            bool cache_Connectors_Indicator,
            string feedType_Name,
            string dropPath_Text,
            string feedPathOverride_Text,
            string packageStoreConfiguration_Xml,
            byte[] syncToken_Bytes,
            string syncTarget_Url)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(feed_Name).Capitalize(), feed_Name),
                new NamedValue(nameof(feed_Description).Capitalize(), feed_Description),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cache_Connectors_Indicator).Capitalize(), cache_Connectors_Indicator.ToYnIndicator()),
                new NamedValue(nameof(feedType_Name).Capitalize(), feedType_Name),
                new NamedValue(nameof(dropPath_Text).Capitalize(), dropPath_Text),
                new NamedValue(nameof(feedPathOverride_Text).Capitalize(), feedPathOverride_Text),
                new NamedValue(nameof(packageStoreConfiguration_Xml).Capitalize(), packageStoreConfiguration_Xml),
                new NamedValue(nameof(syncToken_Bytes).Capitalize(), syncToken_Bytes),
                new NamedValue(nameof(syncTarget_Url).Capitalize(), syncTarget_Url)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_SetFeedPropertyAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the license urls for a particlar feed
        /// </summary>
        public async Task<bool> Feeds_SetLicenseUrlsAsync(
            int feed_Id,
            string licenseUrls_Xml)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(licenseUrls_Xml).Capitalize(), licenseUrls_Xml)
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_SetLicenseUrlsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets one or more properties on a feed of any type
        /// </summary>
        public async Task<bool> Feeds_SetNuGetFeedPropertyAsync(
            int feed_Id,
            string aPIKey_Text,
            bool symbolServerEnabled_Indicator,
            bool stripSymbolFiles_Indicator,
            bool legacy_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(aPIKey_Text).Capitalize(), aPIKey_Text),
                new NamedValue(nameof(symbolServerEnabled_Indicator).Capitalize(), symbolServerEnabled_Indicator.ToYnIndicator()),
                new NamedValue(nameof(stripSymbolFiles_Indicator).Capitalize(), stripSymbolFiles_Indicator.ToYnIndicator()),
                new NamedValue(nameof(legacy_Indicator).Capitalize(), legacy_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_SetNuGetFeedPropertyAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates sync settings for a feed
        /// </summary>
        public async Task<bool> Feeds_UpdateSyncSettingsAsync(
            int feed_Id,
            string sync_Url,
            string remoteFeed_Name,
            byte[] remoteFeed_APIKey_Bytes,
            int sync_Frequency_Minutes,
            bool active_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(sync_Url).Capitalize(), sync_Url),
                new NamedValue(nameof(remoteFeed_Name).Capitalize(), remoteFeed_Name),
                new NamedValue(nameof(remoteFeed_APIKey_Bytes).Capitalize(), remoteFeed_APIKey_Bytes),
                new NamedValue(nameof(sync_Frequency_Minutes).Capitalize(), sync_Frequency_Minutes),
                new NamedValue(nameof(active_Indicator).Capitalize(), active_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(Feeds_UpdateSyncSettingsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
