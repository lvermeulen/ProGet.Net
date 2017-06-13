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
        /// Gets the Docker image with the specified tag or digest
        /// </summary>
        public async Task<DockerImage> DockerImages_GetImageAsync(
            int feed_Id,
            string repository_Name,
            string tagOrDigest_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(repository_Name).Capitalize(), repository_Name),
                new NamedValue(nameof(tagOrDigest_Name).Capitalize(), tagOrDigest_Name)
            );

            return await ExecuteNativeApiMethodAsync<DockerImage>(nameof(DockerImages_GetImageAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Docker images that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<DockerImage>> DockerImages_GetImagesAsync(
            int feed_Id,
            string repository_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(repository_Name).Capitalize(), repository_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DockerImage>>(nameof(DockerImages_GetImagesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Docker repositories that match the specified criteria
        /// </summary>
        public async Task<IEnumerable<DockerRepository>> DockerImages_GetRepositoriesAsync(
            int feed_Id,
            string searchTerm_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(searchTerm_Text).Capitalize(), searchTerm_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DockerRepository>>(nameof(DockerImages_GetRepositoriesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Docker image tags for the specified repository
        /// </summary>
        public async Task<IEnumerable<DockerImageTag>> DockerImages_GetTagsAsync(
            int feed_Id,
            string repository_Name)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(repository_Name).Capitalize(), repository_Name)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<DockerImageTag>>(nameof(DockerImages_GetTagsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the short or full description of a Docker repository
        /// </summary>
        public async Task<bool> DockerImages_UpdateDescriptionAsync(
            int feed_Id,
            string repository_Name,
            string shortDescription_Text,
            string fullDescription_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(repository_Name).Capitalize(), repository_Name),
                new NamedValue(nameof(shortDescription_Text).Capitalize(), shortDescription_Text),
                new NamedValue(nameof(fullDescription_Text).Capitalize(), fullDescription_Text)
            );

            return await ExecuteNativeApiMethodAsync(nameof(DockerImages_UpdateDescriptionAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
