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
    public partial class SupplierModule : Form
    {
        ISupplierService supplierService;
        CreateMessage createMessage;
        public SupplierModule()
        {
            supplierService = InstanceFactory.GetInstance<ISupplierService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void SupplierModul_Load(object sender, EventArgs e)
        {
            SupplierGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SupplierGridView.ReadOnly = true;
            SupplierGridView.ColumnCount = 4;
            SupplierGridView.Columns[0].Name = "ID";
            SupplierGridView.Columns[1].Name = "Firma Adı";
            SupplierGridView.Columns[2].Name = "E-Posta";
            SupplierGridView.Columns[3].Name = "Telefon";
            SupplierGridViewGetAll();

        }

        private void SupplierGridViewGetAll()
        {
            SupplierGridView.Rows.Clear();
            foreach (var supplier in supplierService.GetAll())
            {
                string[] row = new string[] {
                supplier.Id.ToString(),
                supplier.CompanyName,
                supplier.EMail,
                supplier.PhoneNumber };
                SupplierGridView.Rows.Add(row);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier
                {
                    CompanyName = CreateCompanyNameTxt.Text,
                    EMail = CreateEMailTxt.Text,
                    PhoneNumber = CreatePhoneNumberTxt.Text,
                };
                createMessage.CreateMessageBox(supplierService.Add(supplier));
                SupplierGridViewGetAll();
                CreateCompanyNameTxt.Text = "";
                CreateEMailTxt.Text = "";
                CreatePhoneNumberTxt.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier
                {
                    Id = Convert.ToInt32(SupplierGridView.SelectedRows[0].Cells[0].Value.ToString()),
                    CompanyName = EditCompanyNameTxt.Text,
                    EMail = EditEMailTxt.Text,
                    PhoneNumber = EditPhoneNumberTxt.Text,
                };
                createMessage.CreateMessageBox(supplierService.Update(supplier));
                EditCompanyNameTxt.Text = "";
                EditEMailTxt.Text = "";
                EditPhoneNumberTxt.Text = "";
                SupplierGridViewGetAll();
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
                createMessage.CreateMessageBox(supplierService.Delete(Convert.ToInt32(SupplierGridView.SelectedRows[0].Cells[0].Value.ToString())));
                EditCompanyNameTxt.Text = "";
                EditEMailTxt.Text = "";
                EditPhoneNumberTxt.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }
        }
    }
}
