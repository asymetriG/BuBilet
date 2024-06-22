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
    public partial class AdminPanel : Form
    {
        public static int pay = 1000;
        public static string currency = "TL";

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Company c in Company.Companies)
            {       
                listBox1.Items.Add(c.name);
            }
            servicePay.Text = pay + " " + currency;
        }


        private void removeCompany_Click(object sender, EventArgs e)
        {
            if(Company.Companies.Count==0)
            {
                MessageBox.Show("Hiç şirket yok");
                return;
            }
            Admin.removeCompany();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Company c in Company.Companies)
            {
                listBox1.Items.Add(c.name);
            }
            servicePay.Text = pay + " " + currency;

        }

        private void addCompany_Click(object sender, EventArgs e)
        {
            AddCompanyForm acf = new AddCompanyForm();
            acf.ShowDialog();
        }

        private void servicePay_Click(object sender, EventArgs e)
        {

        }

        private void set_Click(object sender, EventArgs e)
        {

        }

        private void setPay_Click(object sender, EventArgs e)
        {
            Admin.setServicePrice();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
