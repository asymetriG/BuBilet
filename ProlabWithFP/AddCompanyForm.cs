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
    public partial class AddCompanyForm : Form
    {
        public AddCompanyForm()
        {
            InitializeComponent();
        }


        private void AddCompanyForm_Load(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            //(firmUserName.Text,firmPassword.Text,firmName.Text
            if (firmUserName.Text=="" || firmPassword.Text=="" || firmName.Text=="")
            {
                return false;
            }
            return true;
        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            bool found = false;
            if(!validate())
            {
                MessageBox.Show("Tüm bilgileri eksiksiz giriniz!");
                return;
            }

            foreach (Company c in Company.Companies) {
                if((c.username == firmUserName.Text) || (c.name == firmName.Text))
                {
                    MessageBox.Show("Bu firma adında veya kullanıcı adında zaten bir firma var", "Failure");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Company company = new Company(firmUserName.Text,firmPassword.Text,firmName.Text);
                Admin.addCompany(company);

                MessageBox.Show("Firma başarıyla oluşturuldu", "Success");
                this.Close();
            }
        }
    }
}
