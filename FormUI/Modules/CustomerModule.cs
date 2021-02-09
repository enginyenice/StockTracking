using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class CustomerModule : Form
    {
        ICustomerService customerService;
        CreateMessage createMessage;
        public CustomerModule()
        {
            customerService = InstanceFactory.GetInstance<ICustomerService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = CreateFirstNameTxt.Text,
                    LastName = CreateLastNameTxt.Text,
                    CompanyName = CreateCompanyNameTxt.Text,
                    EMail = CreateEMailTxt.Text,
                    PhoneNumber = CreatePhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(customerService.Add(customer));
                CustomerGridViewGetAll();
                CreateFirstNameTxt.Text = "";
                CreateLastNameTxt.Text = "";
                CreateCompanyNameTxt.Text = "";
                CreateEMailTxt.Text = "";
                CreatePhoneNumberTxt.Text = "";
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Tekrar deneyiniz...");
            }
        }

        private void CustomerModul_Load(object sender, EventArgs e)
        {
            CustomerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerGridView.ReadOnly = true;
            CustomerGridView.ColumnCount = 6;
            CustomerGridView.Columns[0].Name = "ID";
            CustomerGridView.Columns[1].Name = "Firma Adı";
            CustomerGridView.Columns[2].Name = "Ad";
            CustomerGridView.Columns[3].Name = "Soyad";
            CustomerGridView.Columns[4].Name = "E-Posta";
            CustomerGridView.Columns[5].Name = "Telefon";
            
            CustomerGridViewGetAll();
        }
        private void CustomerGridViewGetAll()
        {
            CustomerGridView.Rows.Clear();
            foreach (var customer in customerService.GetAll())
            {
                string[] row = new string[] { 
                customer.Id.ToString(), 
                customer.CompanyName, 
                customer.FirstName, 
                customer.LastName, 
                customer.EMail,
                customer.PhoneNumber};
                CustomerGridView.Rows.Add(row);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Id = Convert.ToInt32(CustomerGridView.SelectedRows[0].Cells[0].Value.ToString()),
                    FirstName = EditFirstNameTxt.Text,
                    LastName = EditLastNameTxt.Text,
                    CompanyName = EditCompanyNameTxt.Text,
                    EMail = EditEMailTxt.Text,
                    PhoneNumber = EditPhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(customerService.Update(customer));
                CustomerGridViewGetAll();
                EditFirstNameTxt.Text = "";
                EditLastNameTxt.Text = "";
                EditCompanyNameTxt.Text = "";
                EditEMailTxt.Text = "";
                EditPhoneNumberTxt.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                createMessage.CreateMessageBox(customerService.Delete(Convert.ToInt32(CustomerGridView.SelectedRows[0].Cells[0].Value.ToString())));
                CustomerGridViewGetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }
        }

        private void CustomerGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomerGridView.SelectedCells.Count > 0 && CustomerGridView.SelectedRows[0].Cells[0].Value != null)
            {
                EditPhoneNumberTxt.Text = CustomerGridView.SelectedRows[0].Cells[5].Value.ToString();
                EditEMailTxt.Text = CustomerGridView.SelectedRows[0].Cells[4].Value.ToString();
                EditLastNameTxt.Text = CustomerGridView.SelectedRows[0].Cells[3].Value.ToString();
                EditFirstNameTxt.Text = CustomerGridView.SelectedRows[0].Cells[2].Value.ToString();
                EditCompanyNameTxt.Text = CustomerGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
