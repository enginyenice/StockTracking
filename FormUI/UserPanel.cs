using Entities.Concrete;
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
    }
}
