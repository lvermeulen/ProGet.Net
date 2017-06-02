namespace ProGet.Net.Tests
{
    public partial class ProGetClientShould
    {
        private readonly ProGetClient _client;

        public ProGetClientShould()
        {
            _client = new ProGetClient("", "");
        }
    }
}
