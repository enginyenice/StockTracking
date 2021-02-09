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
            UserModul userModul = new UserModul();
            userModul.Show();
        }
    }
}
