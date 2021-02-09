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
    public partial class StoreModul : Form
    {
        IStoreService storeService;
        CreateMessage createMessage;

        public StoreModul()
        {
            storeService = InstanceFactory.GetInstance<IStoreService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void StoreModul_Load(object sender, EventArgs e)
        {
            StoreGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StoreGridView.ReadOnly = true;
            StoreGridView.ColumnCount = 4;
            StoreGridView.Columns[0].Name = "ID";
            StoreGridView.Columns[1].Name = "Depo Adı";
            StoreGridView.Columns[2].Name = "Telefon";
            StoreGridView.Columns[3].Name = "Adres";
            StoreGridViewGetAll();
        }

        private void StoreGridViewGetAll()
        {
            StoreGridView.Rows.Clear();
            foreach (var store in storeService.GetAll())
            {
                string[] row = new string[] {
                store.Id.ToString(),
                store.Name,
                store.PhoneNumber,
                store.Address
                
                };
                StoreGridView.Rows.Add(row);
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
                    Id = Convert.ToInt32(StoreGridView.SelectedRows[0].Cells[0].Value.ToString()),
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
                createMessage.CreateMessageBox(storeService.Delete(Convert.ToInt32(StoreGridView.SelectedRows[0].Cells[0].Value.ToString())));
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
    }
}
