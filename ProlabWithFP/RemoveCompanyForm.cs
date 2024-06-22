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
    public partial class RemoveCompanyForm : Form
    {
        public AdminPanel ap;
        public RemoveCompanyForm()
        {
            InitializeComponent();
        }

        private void RemoveCompanyForm_Load(object sender, EventArgs e)
        {
            foreach(Company c in Company.Companies) {
                comboBox1.Items.Add(c.name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void removeCompany_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Firma Başarıyla Silindi " + comboBox1.SelectedItem, "Success");
            Company.Companies.RemoveAt(comboBox1.SelectedIndex);
            this.Close();
        }
    }
}
