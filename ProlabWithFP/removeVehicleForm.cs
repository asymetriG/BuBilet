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

    public partial class removeVehicleForm : Form
    {
        public Company company;

        public removeVehicleForm()
        {
            InitializeComponent();
        }

        private void removeVehicleForm_Load(object sender, EventArgs e)
        {
            foreach(Bus b in company.busList)
            {
                comboBox1.Items.Add(b);
            }
            foreach (Airplane a in company.airplaneList)
            {
                comboBox1.Items.Add(a);
            }
            foreach (Train t in company.trainList)
            {
                comboBox1.Items.Add(t);
            }
            if(comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void removeVehicle_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem is Bus)
            {
                company.busList.Remove(comboBox1.SelectedItem as Bus);
            }
            else if (comboBox1.SelectedItem is Airplane)
            {
                company.airplaneList.Remove(comboBox1.SelectedItem as Airplane);
            }
            else if (comboBox1.SelectedItem is Train)
            {
                company.trainList.Remove(comboBox1.SelectedItem as Train);
            }
            MessageBox.Show("Araç Başarıyla Silindi");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
