using LibraryAPI.Models;

namespace LibraryAPI.Data
{
    public static class UserRepository
    {
        private static List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "1234", Role = "Admin" },
            new User { Id = 2, Username = "user", Password = "abcd", Role = "User" }
        };

        public static User GetUser(string username, string password)
        {
            return Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
