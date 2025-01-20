using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new();

        public void AddUser(User user) => _users.Add(user);
        public User GetUser(int id) => _users.FirstOrDefault(u => u.Id == id);
        public void UpdateUser(User user)
        {
            var existing = GetUser(user.Id);
            if (existing != null)
            {
                existing.Name = user.Name;
                existing.Email = user.Email;
            }
        }
        public void DeleteUser(int id) => _users.RemoveAll(u => u.Id == id);
        public List<User> GetAllUsers() => _users;
    }
}
