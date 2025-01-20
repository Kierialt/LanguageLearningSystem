using LanguageLearningSystem1.Models;

namespace LanguageLearningSystem1.Services
{
    public interface IUserService
    {
        void AddUser(User user);
        User GetUser(int id);
        void UpdateUser(User user);
        void DeleteUser(int id);
        List<User> GetAllUsers();
    }
}
