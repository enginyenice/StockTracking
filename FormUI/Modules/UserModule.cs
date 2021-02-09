using Business.Abstract;
using Business.Ninject;
using Entities.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public partial class UserModule : Form
    {
        readonly IUserService userService;
        CreateMessage createMessage;
        public UserModule()
        {
            createMessage = new CreateMessage();
            userService = InstanceFactory.GetInstance<IUserService>();
            InitializeComponent();
        }

        private void UserModul_Load(object sender, EventArgs e)
        {
            UserGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserGridView.ReadOnly = true;
            UserGridView.ColumnCount = 7;
            UserGridView.Columns[0].Name = "ID";
            UserGridView.Columns[1].Name = "Ad";
            UserGridView.Columns[2].Name = "Soyad";
            UserGridView.Columns[3].Name = "E-Posta";
            UserGridView.Columns[4].Name = "Telefon";
            UserGridView.Columns[5].Name = "Kullanıcı Adı";
            UserGridView.Columns[6].Name = "Şifre";
            UserGridViewGetAll();
        }

        private void UserGridViewGetAll()
        {
            UserGridView.Rows.Clear();
            foreach (var user in userService.GetAll())
            {
                string[] row = new string[] { user.Id.ToString(), user.FirstName, user.LastName, user.EMail, user.PhoneNumber, user.UserName, user.Password };
                UserGridView.Rows.Add(row);
            }
        }

        private void UserGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (UserGridView.SelectedCells.Count > 0 && UserGridView.SelectedRows[0].Cells[0].Value != null)
            {
                EditPasswordTxt.Text = UserGridView.SelectedRows[0].Cells[6].Value.ToString();
                EditUserNameTxt.Text = UserGridView.SelectedRows[0].Cells[5].Value.ToString();
                EditPhoneNumberTxt.Text = UserGridView.SelectedRows[0].Cells[4].Value.ToString();
                EditEMailTxt.Text = UserGridView.SelectedRows[0].Cells[3].Value.ToString();
                EditLastNameTxt.Text = UserGridView.SelectedRows[0].Cells[2].Value.ToString();
                EditFirstNameTxt.Text = UserGridView.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User
                {
                    UserName = CreateUserNameTxt.Text,
                    Password = CreatePasswordTxt.Text,
                    EMail = CreateEMailTxt.Text,
                    FirstName = CreateFirstNameTxt.Text,
                    LastName = CreateLastNameTxt.Text,
                    PhoneNumber = CreatePhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(userService.Add(newUser));
                UserGridViewGetAll();
                CreateUserNameTxt.Text = "";
                CreatePasswordTxt.Text = "";
                CreateEMailTxt.Text = "";
                CreateFirstNameTxt.Text = "";
                CreateLastNameTxt.Text = "";
                CreatePhoneNumberTxt.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz");
            }





        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User
                {
                    Id = Convert.ToInt32(UserGridView.SelectedRows[0].Cells[0].Value.ToString()),
                    UserName = EditUserNameTxt.Text,
                    Password = EditPasswordTxt.Text,
                    EMail = EditEMailTxt.Text,
                    FirstName = EditFirstNameTxt.Text,
                    LastName = EditLastNameTxt.Text,
                    PhoneNumber = EditPhoneNumberTxt.Text
                };
                createMessage.CreateMessageBox(userService.Update(newUser));
                UserGridViewGetAll();
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
                createMessage.CreateMessageBox(userService.Delete(Convert.ToInt32(UserGridView.SelectedRows[0].Cells[0].Value.ToString())));
                UserGridViewGetAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Tekrar deneyiniz");
            }

        }
    }
}
