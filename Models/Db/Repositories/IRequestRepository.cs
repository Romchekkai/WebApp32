using WebApp32.Models.Db.Entities;

namespace WebApp32.Models.Db.Repositories
{
    public interface IRequestRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequest();
    }
}
