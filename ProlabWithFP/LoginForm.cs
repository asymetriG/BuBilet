using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProlabWithFP
{
    public partial class LoginForm : Form
    {
        public string fromWhere;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(fromWhere.Equals("firm"))
            {
                loginText.Text = "Firma Paneli Giriş";
                this.Text = "Firma Panel";
            }
            else
            {
                loginText.Text = "Admin Paneli Giriş";
                this.Text = "Admin Panel";
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string _username = usernameText.Text;
            string _password = passwordText.Text;

            string login_name = "";

            Company mainCompany = null;

            bool found_company = false;

            if (fromWhere.Equals("admin"))
            {

                if (Admin.realAdmin.password == _password && Admin.realAdmin.username == _username)
                {                 
                    MessageBox.Show("Giriş Başarılı", "Success");
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Veya Şifre!");
                    usernameText.Clear();
                    passwordText.Clear();
                }
            }
            else
            {
                foreach (Company company in Company.Companies)
                {
                    if(_username==company.username && _password==company.password)
                    {
                        found_company = true;
                        login_name= company.name;
                        mainCompany = company;
                        break;
                    }
                }
                if(found_company)
                {
                    MessageBox.Show("Giriş Başarılı sevgili " + login_name, "Success");

                    FirmPanel fp = new FirmPanel();
                    fp.company = mainCompany;
                    fp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre", "Failure");
                    usernameText.Clear();
                    passwordText.Clear();
                }
            }
            
        }


        private void usernameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void passwordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void loginText_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
