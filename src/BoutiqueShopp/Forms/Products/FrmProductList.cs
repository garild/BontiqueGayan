using BoutiqueShopp.Domain;
using BoutiqueShopp.Infrastructure.DTO;
using ComponentFactory.Krypton.Toolkit;
using SkyReg.Common.Extensions;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace BoutiqueShopp.Forms.Products
{
    public partial class FrmProductList : KryptonForm
    {
        private FrmAddEditProduct FrmAddEditProduct;
        private readonly IProductRepository _productRepository;
        public FrmProductList(IProductRepository productRepository)
        {
            InitializeComponent();

            _productRepository = productRepository;
        }

        private void btn_Search_Click(object sender, System.EventArgs e)
        {
            LoadProductList();
        }

        private void LoadProductList()
        {
            productDTOBindingSource.DataSource = null;
            var products = new List<Product>();
            products = _productRepository.GetAll();

            var productList = products.Select(p =>
            {
                Image image = default;
                using (MemoryStream mStream = new MemoryStream(p.Image))
                {
                    image = Image.FromStream(mStream);
                }

                return new ProductDTO
                {
                    Category = p.Category,
                    Code = p.Code,
                    Color = p.Color,
                    Description = p.Description,
                    Id = p.Id,
                    Image = image,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    Size = $"{p.Size}/{p.GeneralSize}"
                };
            });


            productDTOBindingSource.DataSource = productList;
            ProductDataGrid.DataSource = productDTOBindingSource;
        }

        private void btn_AddCustomer_Click(object sender, System.EventArgs e)
        {
            FormsOpened<FrmAddEditProduct>.OpenForm(FrmAddEditProduct, _productRepository);
            LoadProductList();
        }
    }
}
