
using Database;

namespace BoutiqueShopp.Domain
{
    public interface IUserRepository
    {
        int Create(Users user);
        void Update(Users user);
        Users Find(string login, string hashedPassword);
    }
}
