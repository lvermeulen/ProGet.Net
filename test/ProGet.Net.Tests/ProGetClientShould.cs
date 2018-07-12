using System.IO;
using Microsoft.Extensions.Configuration;

namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        private readonly ProGetClient _client;

        public ProGetClientShould()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
            _client = new ProGetClient(configuration["progetUrl"], configuration["apiKey"]);
        }
    }
}
