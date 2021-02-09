using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Login : Form
    {
        readonly IUserService userService;
        public User LoginUser;
        
        public Login()
        {
            userService = InstanceFactory.GetInstance<IUserService>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            
            bool LoginCheck = userService.LoginControl(new User { UserName = UserNameTxt.Text, Password = PasswordTxt.Text });
            if (LoginCheck)
            {
                LoginUser = userService.GetUsernamePassword(new User { UserName = UserNameTxt.Text, Password = PasswordTxt.Text });
                switch (PanelCbx.SelectedIndex)
                {
                    case 0:
                        AdministratorPanel administratorPanel = new AdministratorPanel(LoginUser);
                        administratorPanel.Show();
                        this.Hide();
                        break;
                    case 1:
                        UserPanel userPanel = new UserPanel(LoginUser);
                        userPanel.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Hatalı seçim yaptınız.");
                        break;
                }



            }
        }
    }
}
