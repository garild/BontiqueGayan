using BoutiqueShopp.Domain;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Win32;
using SkyReg.Common.Extensions;
using System.Drawing;
using System.IO;

namespace BoutiqueShopp.Forms.Products
{
    public partial class FrmAddEditProduct : KryptonForm
    {
        private readonly IProductRepository _productRepository;
        private Image DefaultImage = default;
        private FileDialog fileDialog;
        public FrmAddEditProduct(IProductRepository productRepository)
        {
            InitializeComponent();

            DefaultImage = PreviewProductImage.Image;

            _productRepository = productRepository;
            Txt_Quantity.Minimum = 1;
        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            var resizedImage = (Image)(new Bitmap(Image.FromFile(fileDialog.FileName), 150, 150));

            var product = new Product
            {
                Name = Txt_Name.Text.TrimToLower(),
                Description = Txt_Description.Text.TrimToLower(),
                Code = Txt_Code.Text.TrimToLower(),
                GeneralSize = Txt_GeneralSize.Text.TrimToLower(),
                Size = Txt_Size.Text.TrimToLower(),
                Category = Txt_Category.Text.TrimToLower(),
                Color = Txt_Color.Text.TrimToLower(),
                Quantity = (int)Txt_Quantity.Value,
                Image = resizedImage.ImageToByte()
            };

            _productRepository.Create(product);

           
        }

        private void btn_Addimage_Click(object sender, System.EventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files (JPG,PNG,BMP)|*.JPG;*.JPEG;*.PNG;*.BMP";
            fileDialog.ShowDialog();

            PreviewProductImage.Image = Image.FromFile(fileDialog.FileName);
        }
    }
}
