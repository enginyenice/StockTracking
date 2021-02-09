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
    public partial class ProductModule : Form
    {
        IProductService productService;
        CreateMessage createMessage;
        public ProductModule()
        {
            productService = InstanceFactory.GetInstance<IProductService>();
            createMessage = new CreateMessage();
            InitializeComponent();
        }

        private void ProductModul_Load(object sender, EventArgs e)
        {
            ProductGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGridView.ReadOnly = true;
            ProductGridView.ColumnCount = 6;
            ProductGridView.Columns[0].Name = "ID";
            ProductGridView.Columns[1].Name = "Cinsi";
            ProductGridView.Columns[2].Name = "Birimi";
            ProductGridView.Columns[3].Name = "Açıklama";
            ProductGridView.Columns[4].Name = "Resim";
            ProductGridView.Columns[5].Name = "Kritik Stok Sayısı";

            ProductGridViewGetAll();
        }

        private void ProductGridViewGetAll()
        {
            ProductGridView.Rows.Clear();
            foreach (var product in productService.GetAll())
            {
                string[] row = new string[] {
                product.Id.ToString(),
                product.Type,
                product.Unit,
                product.Description,
                product.Image,
                product.CriticalStock.ToString()
                };
                ProductGridView.Rows.Add(row);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                   Type = CreateTypeTxt.Text,
                   Unit = CreateUnitTxt.Text,
                   Description = CreateDescriptionTxt.Text,
                   Image = CreateImageTxt.Text,
                   CriticalStock = (CreateCriticalStockTxt.Text != "") ? Convert.ToInt32(CreateCriticalStockTxt.Text) : -1
                };
                createMessage.CreateMessageBox(productService.Add(product));
                ProductGridViewGetAll();
                CreateTypeTxt.Text = "";
                CreateUnitTxt.Text = "";
                CreateDescriptionTxt.Text = "";
                CreateImageTxt.Text = "";
                CreateCriticalStockTxt.Text = "";
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
                Product product = new Product
                {
                    Id = Convert.ToInt32(ProductGridView.SelectedRows[0].Cells[0].Value.ToString()),
                    Type = EditTypeTxt.Text,
                    Unit = EditUnitTxt.Text,
                    Description = EditDescriptionTxt.Text,
                    Image = EditImageTxt.Text,
                    CriticalStock = (EditCriticalStockTxt.Text != "") ? Convert.ToInt32(EditCriticalStockTxt.Text) : -1
                };
                createMessage.CreateMessageBox(productService.Update(product));
                ProductGridViewGetAll();
                CreateTypeTxt.Text = "";
                CreateUnitTxt.Text = "";
                CreateDescriptionTxt.Text = "";
                CreateImageTxt.Text = "";
                CreateCriticalStockTxt.Text = "";
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
                createMessage.CreateMessageBox(productService.Delete(Convert.ToInt32(ProductGridView.SelectedRows[0].Cells[0].Value.ToString())));
                ProductGridViewGetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz...");
            }
        }

        private void ProductGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductGridView.SelectedCells.Count > 0 && ProductGridView.SelectedRows[0].Cells[0].Value != null)
            {
                EditCriticalStockTxt.Text = ProductGridView.SelectedRows[0].Cells[5].Value.ToString();
                EditImageTxt.Text = ProductGridView.SelectedRows[0].Cells[4].Value.ToString();
                EditDescriptionTxt.Text = ProductGridView.SelectedRows[0].Cells[3].Value.ToString();
                EditUnitTxt.Text = ProductGridView.SelectedRows[0].Cells[2].Value.ToString();
                EditTypeTxt.Text = ProductGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
