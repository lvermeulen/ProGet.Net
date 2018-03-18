﻿using System;
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
        /// Creates a new package or updates an existing one
        /// </summary>
        //TODO returns PackageHashRequired_Indicator?
        public async Task<int> NuGetPackagesV2_CreateOrUpdatePackageAsync(
            int feed_Id,
            string package_Id,
            string version_Text,
            string targetFrameworks_Text,
            DateTime published_Date,
            long package_Size,
            byte[] packageHash_Bytes,
            byte[] nuspecFile_Bytes,
            bool symbols_Indicator,
            bool source_Indicator,
            bool cached_Indicator,
            string symbolFiles_Xml,
            bool listed_Indicator,
            int download_Count,
            bool packageHashRequired_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Id).Capitalize(), package_Id),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text),
                new NamedValue(nameof(targetFrameworks_Text).Capitalize(), targetFrameworks_Text),
                new NamedValue(nameof(published_Date).Capitalize(), published_Date.ToJsonDateTime()),
                new NamedValue(nameof(package_Size).Capitalize(), package_Size),
                new NamedValue(nameof(packageHash_Bytes).Capitalize(), packageHash_Bytes),
                new NamedValue(nameof(nuspecFile_Bytes).Capitalize(), nuspecFile_Bytes),
                new NamedValue(nameof(symbols_Indicator).Capitalize(), symbols_Indicator.ToYnIndicator()),
                new NamedValue(nameof(source_Indicator).Capitalize(), source_Indicator.ToYnIndicator()),
                new NamedValue(nameof(cached_Indicator).Capitalize(), cached_Indicator.ToYnIndicator()),
                new NamedValue(nameof(symbolFiles_Xml).Capitalize(), symbolFiles_Xml),
                new NamedValue(nameof(listed_Indicator).Capitalize(), listed_Indicator.ToYnIndicator()),
                new NamedValue(nameof(download_Count).Capitalize(), download_Count),
                new NamedValue(nameof(packageHashRequired_Indicator).Capitalize(), packageHashRequired_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync<int>(nameof(NuGetPackagesV2_CreateOrUpdatePackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the latest packages in a feed
        /// </summary>
        public async Task<IEnumerable<NuGetPackagesV2Latest>> NuGetPackagesV2_GetLatestAsync(
            int feed_Id,
            string packageIds_Psv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(packageIds_Psv).Capitalize(), packageIds_Psv));

            return await ExecuteNativeApiMethodAsync<IEnumerable<NuGetPackagesV2Latest>>(nameof(NuGetPackagesV2_GetLatestAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the latest stable packages in a feed
        /// </summary>
        public async Task<IEnumerable<NuGetPackagesV2LatestStable>> NuGetPackagesV2_GetLatestStableAsync(
            int feed_Id,
            string packageIds_Psv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(packageIds_Psv).Capitalize(), packageIds_Psv)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NuGetPackagesV2LatestStable>>(nameof(NuGetPackagesV2_GetLatestStableAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a package in a feed
        /// </summary>
        public async Task<IEnumerable<NuGetPackageV2Extended>> NuGetPackagesV2_GetPackageAsync(
            int feed_Id,
            string package_Id,
            string version_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Id).Capitalize(), package_Id),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NuGetPackageV2Extended>>(nameof(NuGetPackagesV2_GetPackageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the packages in a feed
        /// </summary>
        public async Task<IEnumerable<NuGetPackageV2Extended>> NuGetPackagesV2_GetPackagesAsync(
            int feed_Id,
            string packageIds_Psv)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(packageIds_Psv).Capitalize(), packageIds_Psv)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NuGetPackageV2Extended>>(nameof(NuGetPackagesV2_GetPackagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Lists or unlists a NuGet package
        /// </summary>
        public async Task<bool> NuGetPackagesV2_SetListedAsync(
            int feed_Id,
            string package_Id,
            string version_Text,
            bool listed_Indicator)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(package_Id).Capitalize(), package_Id),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text),
                new NamedValue(nameof(listed_Indicator).Capitalize(), listed_Indicator.ToYnIndicator())
            );

            return await ExecuteNativeApiMethodAsync(nameof(NuGetPackagesV2_SetListedAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the best symbol matches
        /// </summary>
        public async Task<IEnumerable<NuGetPackageSymbolsV2Extended>> NuGetPackageSymbolsV2_GetSymbolsAsync(
            int feed_Id,
            string symbol_Id,
            string symbolFileName_Text,
            int symbol_Age)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(symbol_Id).Capitalize(), symbol_Id),
                new NamedValue(nameof(symbolFileName_Text).Capitalize(), symbolFileName_Text),
                new NamedValue(nameof(symbol_Age).Capitalize(), symbol_Age)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<NuGetPackageSymbolsV2Extended>>(nameof(NuGetPackageSymbolsV2_GetSymbolsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
