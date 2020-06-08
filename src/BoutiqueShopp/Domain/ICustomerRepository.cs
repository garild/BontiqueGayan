using System.Collections.Generic;

namespace BoutiqueShopp.Domain
{
    public interface ICustomerRepository
    {
        List<Customer> FindBy(string name, string LastName);
        List<Customer> FindBy(string nick);
        List<Customer> GetAll();
        void Update(Customer customers);
        void Delete(int id);
        Customer Create(Customer customers);
        Customer FindBy(int? customerId);
    }
}
