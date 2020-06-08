using System.Drawing;

namespace BoutiqueShopp.Infrastructure.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Image Image { get; set; }
    }
}
