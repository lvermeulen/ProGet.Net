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
        /// Gets the files associated with a Maven artifact
        /// </summary>
        public async Task<IEnumerable<MavenArtifactFileExtended>> MavenArtifacts_GetArtifactFilesAsync(
            int feed_Id,
            string groupId_Text,
            string artifactId_Text,
            string version_Text,
            string file_Type)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(groupId_Text).Capitalize(), groupId_Text),
                new NamedValue(nameof(artifactId_Text).Capitalize(), artifactId_Text),
                new NamedValue(nameof(version_Text).Capitalize(), version_Text),
                new NamedValue(nameof(file_Type).Capitalize(), file_Type)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<MavenArtifactFileExtended>>(nameof(MavenArtifacts_GetArtifactFilesAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the Maven artifacts in a feed
        /// </summary>
        public async Task<IEnumerable<MavenArtifactExtended>> MavenArtifacts_GetArtifactsAsync(
            int feed_Id,
            string groupId_Text,
            string artifactId_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(groupId_Text).Capitalize(), groupId_Text),
                new NamedValue(nameof(artifactId_Text).Capitalize(), artifactId_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<MavenArtifactExtended>>(nameof(MavenArtifacts_GetArtifactsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets all of the versions of a Maven artifact
        /// </summary>
        public async Task<IEnumerable<MavenArtifactVersion>> MavenArtifacts_GetArtifactVersionsAsync(
            int feed_Id,
            string groupId_Text,
            string artifactId_Text)
        {
            var queryParamValues = QueryParamValues.From(
                new NamedValue(nameof(feed_Id).Capitalize(), feed_Id),
                new NamedValue(nameof(groupId_Text).Capitalize(), groupId_Text),
                new NamedValue(nameof(artifactId_Text).Capitalize(), artifactId_Text)
            );

            return await ExecuteNativeApiMethodAsync<IEnumerable<MavenArtifactVersion>>(nameof(MavenArtifacts_GetArtifactVersionsAsync).WithoutAsyncSuffix(), queryParamValues).ConfigureAwait(false);
        }
    }
}
