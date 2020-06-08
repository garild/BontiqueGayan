using System.Drawing;

namespace BoutiqueShopp.Domain
{
    public interface IProductRepository
    {
        Product Create(Product data);
        Product Update(Product data);
        Image UpdateImage(byte[] data);
    }
}
