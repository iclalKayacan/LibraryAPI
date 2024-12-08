using LibraryAPI.Data;
using LibraryAPI.Models;
using LibraryAPI.Repositories;
using System.Linq;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public User GetUserByUsername(string username)
    {
        return _context.Users.SingleOrDefault(u => u.Username == username);
    }
}
