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
    public partial class StoreModule : Form
    {
        IStoreService storeService;
        CreateMessage createMessage;

        public StoreModule()
        {
            storeService = InstanceFactory.GetInstance<IStoreService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void StoreModul_Load(object sender, EventArgs e)
        {
            TransferBtn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransferBtn.ReadOnly = true;
            TransferBtn.ColumnCount = 4;
            TransferBtn.Columns[0].Name = "ID";
            TransferBtn.Columns[1].Name = "Depo Adı";
            TransferBtn.Columns[2].Name = "Telefon";
            TransferBtn.Columns[3].Name = "Adres";
            StoreGridViewGetAll();
        }

        private void StoreGridViewGetAll()
        {
            TransferBtn.Rows.Clear();
            foreach (var store in storeService.GetAll())
            {
                string[] row = new string[] {
                store.Id.ToString(),
                store.Name,
                store.PhoneNumber,
                store.Address
                
                };
                TransferBtn.Rows.Add(row);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Store store = new Store
                {
                    Address = CreateAddressTxt.Text,
                    Name = CreateStoreNameTxt.Text,
                    PhoneNumber = CreatePhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(storeService.Add(store));
                CreateAddressTxt.Text = "";
                CreateStoreNameTxt.Text = "";
                CreatePhoneNumberTxt.Text = "";
                StoreGridViewGetAll();
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
                Store store = new Store
                {
                    Id = Convert.ToInt32(TransferBtn.SelectedRows[0].Cells[0].Value.ToString()),
                    Address = EditAddressTxt.Text,
                    Name = EditStoreNameTxt.Text,
                    PhoneNumber = EditPhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(storeService.Update(store));
                StoreGridViewGetAll();
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
                createMessage.CreateMessageBox(storeService.Delete(Convert.ToInt32(TransferBtn.SelectedRows[0].Cells[0].Value.ToString())));
                EditStoreNameTxt.Text = "";
                EditStoreNameTxt.Text = "";
                EditPhoneNumberTxt.Text = "";
                StoreGridViewGetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductTransferModule productTransferModule = new ProductTransferModule();
            productTransferModule.ShowDialog();
        }
    }
}
