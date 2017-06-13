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
        //DockerImages_GetImage
        //Gets the Docker image with the specified tag or digest.
        //Feed_Id (Int32)
        //Repository_Name(String)
        //TagOrDigest_Name(String)   DataRow(DockerImages)
        
        //DockerImages_GetImages
        //Gets the Docker images that match the specified criteria.
        //Feed_Id(Int32)
        //Repository_Name(String)    DataTable(DockerImages)
        
        //DockerImages_GetRepositories
        //Gets the Docker repositories that match the specified criteria.
        //Feed_Id(Int32)
        //SearchTerm_Text(String)    DataTable(DockerRepositories)
        
        //DockerImages_GetTags
        //Gets the Docker image tags for the specified repository.
        //Feed_Id (Int32)
        //Repository_Name(String)    DataTable(DockerImageTags)
        
        //DockerImages_UpdateDescription
        //Updates the short or full description of a Docker repository.
        //Feed_Id(Int32)
        //Repository_Name(String)
        //ShortDescription_Text(String)
        //FullDescription_Text(String)   none
    }
}
