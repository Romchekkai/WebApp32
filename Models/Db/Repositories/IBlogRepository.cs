using WebApp32.Models.Db.Entities;

namespace WebApp32.Models.Db.Repositories
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
