using FootballApp2.Models;
namespace FootballApp2.Services
{
    public interface IAzureService
    {
        Task<List<BlobModel>> ListAsync();
    }
}
