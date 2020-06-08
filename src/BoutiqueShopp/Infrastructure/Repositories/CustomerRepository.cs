using BoutiqueShopp.Domain;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BoutiqueShopp.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDbConnection _connection;

        public CustomerRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Customer Create(Customer customer)
        {
            var customers = _connection.Query<Customer>("Customers_CreateNew", new
            {
                customer.Name, 
                customer.LastName,
                customer.Nick, 
                customer.PhoneNumber,
                customer.Email,
                customer.Address,
                customer.City,
                customer.PostCode

            }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customers;
        }

        public void Delete(int id)
        {
            _connection.Execute("Customer_DeleteWhereId", new { id }, commandType: CommandType.StoredProcedure);
        }

        public List<Customer> FindBy(string name, string LastName)
        {
            throw new NotImplementedException();
        }

        public List<Customer> FindBy(string nick)
        {
            throw new NotImplementedException();
        }

        public Customer FindBy(int? customerId)
        {
            var customer = _connection.Query<Customer>("Customer_FindById", new { Id = customerId }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return customer;
        }

        public List<Customer> GetAll()
        {
            var customers = _connection.Query<Customer>("Customers_GetAll", null, commandType: CommandType.StoredProcedure).AsList();

            return customers;
        }

        public void Update(Customer customers)
        {
            throw new NotImplementedException();
        }
    }
}
