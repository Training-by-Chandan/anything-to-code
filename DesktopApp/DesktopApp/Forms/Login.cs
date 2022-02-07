using DesktopApp.Service;
using DesktopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.Forms
{
    public partial class Login : Form
    {
        private readonly UserService userService;

        public Login()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //check the validation here
            var model = new LoginViewModel()
            {
                Username = usernameTxt.Text,
                Password = passwordTxt.Text
            };
            var result = userService.Login(model);
            if (!result.Item1)
            {
                MessageBox.Show(result.Item2);
            }
            else
            {
                MainForm m = new MainForm();
                m.Show();
                this.Hide();
            }
        }
    }
}