using BoutiqueShopp.Domain;
using Dapper;
using Database;
using System;
using System.Data;
using System.Linq;

namespace BoutiqueShopp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _connection;

        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public int Create(User user)
        {
            var result = _connection.ExecuteScalar<int>("Users_CreateNew", new
            {
                user.Login,
                user.Name,
                user.HashedPassword
            },commandType: CommandType.StoredProcedure);

            return result;
        }

        public User Find(string login, string hashedPassword)
        {
            var result = _connection.Query<User>("User_FindByLoginAndPassword", new { login, hashedPassword }, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return result;
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
