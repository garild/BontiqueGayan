using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueShopp.Infrastructure.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string GeneralSize { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Image Image { get; set; }
    }
}
