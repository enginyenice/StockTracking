using Entities.Concrete;
using FormUI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI
{
    public partial class UserPanel : Form
    {
    private readonly User _loginUser;
        public UserPanel(User loginUser)
        {
            _loginUser = loginUser;
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductModule productModule = new ProductModule();
            productModule.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuyingProduct buyingProduct = new BuyingProduct();
            buyingProduct.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellingProduct sellingProduct = new SellingProduct();
            sellingProduct.ShowDialog();
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
