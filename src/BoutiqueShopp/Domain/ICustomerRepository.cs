using System.Collections.Generic;

namespace BoutiqueShopp.Domain
{
    public interface ICustomerRepository
    {
        Customers FindBy(string name, string LastName);
        List<Customers> GetAll();
        void Update(Customers customers);
        void Delete(Customers customers);
    }
}
