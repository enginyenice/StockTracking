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
    public partial class AdministratorPanel : Form
    {
        private readonly User _loginUser;
        public AdministratorPanel(User loginUser)
        {
            _loginUser = loginUser;
            InitializeComponent();
        }

        private void AdministratorPanel_Load(object sender, EventArgs e)
        {

        }

        private void UserModuleBtn_Click(object sender, EventArgs e)
        {
            UserModule userModul = new UserModule();
            userModul.ShowDialog();
        }

        private void CustomerModuleBtn_Click(object sender, EventArgs e)
        {
            CustomerModule customerModule = new CustomerModule();
            customerModule.ShowDialog();
        }

        private void SupplierModuleBtn_Click(object sender, EventArgs e)
        {
            SupplierModule supplierModule = new SupplierModule();
            supplierModule.ShowDialog();
        }

        private void StoreModuleBtn_Click(object sender, EventArgs e)
        {
            StoreModule storeModule = new StoreModule();
            storeModule.ShowDialog();
        }

        private void ReportModuleBtn_Click(object sender, EventArgs e)
        {
            ReportingModule reportingModule = new ReportingModule();
            reportingModule.ShowDialog();
        }

        private void AdministratorPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
    }
}
