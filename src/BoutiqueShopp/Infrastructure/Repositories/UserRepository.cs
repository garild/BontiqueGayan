using BoutiqueShopp.Domain;
using Dapper;
using Database;
using Microsoft.SqlServer.Dac.Model;
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

        public int Create(Users user)
        {
            var result = _connection.ExecuteScalar<int>("Users_CreateNew", new
            {
                user.Login,
                user.Name,
                user.HashedPassword
            },commandType: CommandType.StoredProcedure);

            return result;
        }

        public Users Find(string login, string hashedPassword)
        {
            var result = _connection.Query<Users>("User_FindByLoginAndPassword", new { login, hashedPassword }, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return result;
        }

        public void Update(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
