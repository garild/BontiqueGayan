
using Database;

namespace BoutiqueShopp.Domain
{
    public interface IUserRepository
    {
        int Create(User user);
        void Update(User user);
        User Find(string login, string hashedPassword);
    }
}
