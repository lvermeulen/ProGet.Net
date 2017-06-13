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
        //MavenArtifacts_GetArtifactFiles
        //Gets the files associated with a Maven artifact.
        //Feed_Id (Int32)
        //GroupId_Text(String)
        //ArtifactId_Text(String)
        //Version_Text(String)
        //File_Type(String)  DataTable(MavenArtifactFiles_Extended)
        
        //MavenArtifacts_GetArtifacts
        //Gets the Maven artifacts in a feed.
        //Feed_Id(Int32)
        //GroupId_Text(String)
        //ArtifactId_Text(String)    DataTable(MavenArtifacts_Extended)
        
        //MavenArtifacts_GetArtifactVersions
        //Gets all of the versions of a Maven artifact.
        //Feed_Id(Int32)
        //GroupId_Text(String)
        //ArtifactId_Text(String)    DataTable(MavenArtifacts_Versions)
    }
}
