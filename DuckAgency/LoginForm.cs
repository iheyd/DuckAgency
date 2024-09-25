using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckAgency
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ActiveControl = loginButton;
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginText_Enter(object sender, EventArgs e)
        {
            if (loginBox.Text == "Логин")
            {
                loginBox.Text = "";
                loginBox.ForeColor = Color.FromArgb(218, 215, 205);
            }
        }

        private void loginText_Leave(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                loginBox.ForeColor = Color.FromArgb(218, 215, 205);
                loginBox.Text = "Логин";
            }
        }
        
        private void passwordText_Enter(object sender, EventArgs e)
        {
            if (passwordBox.Text == "Пароль")
            {
                passwordBox.Text = "";
                passwordBox.ForeColor = Color.FromArgb(218, 215, 205);
            }
        }

        private void passwordText_Leave(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
            {
                passwordBox.ForeColor = Color.FromArgb(218, 215, 205);
                passwordBox.Text = "Пароль";
            }
        }
        
        private void loginButton_Click(object sender, EventArgs e)
        {
            errorText.Text = "Ошибка!";
        }
    }
}