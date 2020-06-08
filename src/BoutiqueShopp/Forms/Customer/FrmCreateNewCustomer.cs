using BoutiqueShopp.Domain;
using ComponentFactory.Krypton.Toolkit;
using SkyReg;
using SkyReg.Common.Extensions;
using System.Windows.Forms;

namespace BoutiqueShopp.Forms.Customer
{
    public partial class FrmCreateNewCustomer : KryptonForm
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly int? _customerId;
        private readonly ErrorProvider validateControl = null;
        public FrmCreateNewCustomer(ICustomerRepository customerRepository, int? customerId)
        {
            InitializeComponent();
            validateControl = new ErrorProvider();
            _customerRepository = customerRepository;

            _customerId = customerId;

            EditCustomer(customerId);
        }

        private void EditCustomer(int? customerId)
        {
            if (!customerId.HasValue) return;

            var customer = _customerRepository.FindBy(customerId);

            if (customer != default)
            {
                Txt_Nick.Text = customer.Nick;
                Txt_Name.Text = customer.Name;
                Txt_LastName.Text = customer.LastName;
                Txt_Address.Text = customer.Address;
                Txt_PhoneNumber.Text = customer.PhoneNumber;
                Txt_Email.Text = customer.Email;
                Txt_City.Text = customer.City;
                Txt_PostCode.Text = customer.PostCode;
            }

        }

        private void btn_Close_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, System.EventArgs e)
        {
            if (ValidateCustomerData())
            {
                var customer = new Domain.Customer()
                {
                    Nick = Txt_Nick.Text.TrimToLower().DefaultValue(),
                    Name = Txt_Name.Text.TrimToLower().DefaultValue(),
                    LastName = Txt_LastName.Text.TrimToLower().DefaultValue(),
                    Address = Txt_Address.Text.TrimToLower().DefaultValue(),
                    PhoneNumber = Txt_PhoneNumber.Text.TrimToLower().DefaultValue(),
                    Email = Txt_Email.Text.TrimToLower().DefaultValue(),
                    City = Txt_City.Text.TrimToLower().DefaultValue(),
                    PostCode = Txt_PostCode.Text.TrimToLower().DefaultValue(),
                };

                if (!_customerId.HasValue)
                    _customerRepository.Create(customer);
                else
                    _customerRepository.Update(customer);

                KryptonMessageBox.Show("Nowu klient został poprawnie utworzony !,", "Formularz", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private bool ValidateCustomerData()
        {
            bool result = true;
            validateControl.Clear();
            validateControl.BlinkRate = 250;

            if (!Txt_Name.Text.HasValue())
            {
                validateControl.SetError(Txt_Name, "!");
                result = false;
            }
            if (!Txt_LastName.Text.HasValue())
            {
                validateControl.SetError(Txt_LastName, "!");
                result = false;
            }

            if (!Txt_Nick.Text.HasValue())
            {
                validateControl.SetError(Txt_Nick, "!");
                result = false;
            }

            return result;
        }
    }
}
