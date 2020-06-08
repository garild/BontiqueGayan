using System.Collections.Generic;
using System.Drawing;

namespace BoutiqueShopp.Domain
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product Create(Product data);
        Product Update(Product data);
        Image UpdateImage(byte[] data);
    }
}
