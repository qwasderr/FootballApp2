using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using FootballApp2.Models;
namespace FootballApp2.Services
{
    public class AzureService:IAzureService
    {
        private readonly string _CS;
        private readonly string _CN;
        private readonly ILogger<AzureService> _logger;
        public AzureService(IConfiguration config, ILogger<AzureService> logger)
        {
            _CS = config.GetValue<string>("BlobCS");
            _CN = config.GetValue<string>("BlobCN");
            _logger = logger;
        }
        public async Task<List<BlobModel>> ListAsync()
        {
            BlobContainerClient client = new BlobContainerClient(_CS, _CN);
            List<BlobModel> obj = new List<BlobModel>();
            string uri = client.Uri.ToString();
            await foreach (BlobItem file in client.GetBlobsAsync())
            {
                var name = file.Name;
                var fullUri = $"{uri}/{name}";
                obj.Add(new BlobModel
                {
                    Uri = fullUri,
                    Name = name,
                    ContentType = file.Properties.ContentType
                });
            }
            return obj;
        }
    }
}
