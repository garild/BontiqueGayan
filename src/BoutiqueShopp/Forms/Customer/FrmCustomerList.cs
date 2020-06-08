using BoutiqueShopp.Domain;
using BoutiqueShopp.Forms.Customer;
using BoutiqueShopp.Infrastructure.DTO;
using ComponentFactory.Krypton.Toolkit;
using ExtendedControls.ExtendedToolkit.ViewDraw;
using SkyReg.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BoutiqueShopp.Forms.Products
{
    public partial class FrmCustomerList : KryptonForm
    {
        private readonly ICustomerRepository _customerRepository;
        private FrmCreateNewCustomer FrmCreateNewCustomer = null;

        private int CustomerColumnId = -1;
        public FrmCustomerList(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;

            InitializeComponent();
        }

        private void btn_Search_Click(object sender, System.EventArgs e)
        {
            List<Domain.Customer> customer = default;
            var name = txt_Name.Text.ToLower().Trim();
            var lastName = txt_LastName.Text.ToLower().Trim();
            var nick = txt_Nick.Text.ToLower().Trim();

            if (!string.IsNullOrEmpty(name) || !string.IsNullOrEmpty(lastName))
                customer = _customerRepository.FindBy(name, lastName);
            if (!string.IsNullOrEmpty(nick))
            {
                if (customer?.Count > 0)
                    customer = customer.Where(p => p.Nick.Equals(nick, StringComparison.OrdinalIgnoreCase)).ToList();

                customer = _customerRepository.FindBy(nick);
            }
            else
                customer = _customerRepository.GetAll();

            UpdateCustomerDataGrid(customer);
        }

        private void UpdateCustomerDataGrid(List<Domain.Customer> customer)
        {
            customerDtoBindingSource.DataSource = null;

            var customerDto = customer.Select(p =>
            new CustomerDto
            {
                Id = p.Id,
                Name = p.Name,
                LastName = p.LastName,
                Nick = p.Nick,
                Address = Address.Creates(p.Address, null, p.City, p.PostCode),
            });

            if (customerDto?.Count() > 0)
            {
                customerDtoBindingSource.DataSource = customerDto;
                CustomerDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridViewLinkColumn link = new DataGridViewLinkColumn
                {
                    Name = "Edit",
                    UseColumnTextForLinkValue = true,
                    ReadOnly = true,
                    HeaderText = "Akcja",
                    Text = "Edytuj"
                };

                if (!CustomerDataGrid.Columns.Contains("Edit"))
                    CustomerDataGrid.Columns.Add(link);
            }
        }

        private void btn_AddCustomer_Click(object sender, System.EventArgs e)
        {
            FormsOpened<FrmCreateNewCustomer>.OpenForm(FrmCreateNewCustomer, _customerRepository, null);

            var customer = _customerRepository.GetAll();

            UpdateCustomerDataGrid(customer);

            this.Close();
        }

        private void FrmCreateNewCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCreateNewCustomer = null;
        }

        private void CustomerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != CustomerDataGrid.Columns["Edit"].Index)
                return;

            var customerId = CustomerDataGrid.SelectedCells[CustomerColumnId].FormattedValue.ToString();

            FormsOpened<FrmCreateNewCustomer>.OpenForm(FrmCreateNewCustomer, _customerRepository, int.Parse(customerId));
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            int.TryParse(CustomerDataGrid.SelectedCells[CustomerColumnId].FormattedValue.ToString(), out var customerId);
            if (customerId > 0)
            {
                var dialogReuslt = KryptonMessageBox.Show("Czy na pewno chcesz usunąć tego klienta ?", "Usuwanie klienta", MessageBoxButtons.YesNo);

                if (dialogReuslt == DialogResult.No) return;

                _customerRepository.Delete(customerId);
                customerDtoBindingSource.RemoveAt(CustomerDataGrid.SelectedRows[0].Index);
            }
        }

        private void CustomerDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            CustomerColumnId = CustomerDataGrid.Columns["Id"].Index;
        }
    }
}
