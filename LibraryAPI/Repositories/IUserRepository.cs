using LibraryAPI.Models;

namespace LibraryAPI.Repositories
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
    }

}
