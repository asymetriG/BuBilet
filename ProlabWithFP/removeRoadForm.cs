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
    public partial class removeRoadForm : Form
    {
        public Company company;
        public string wayType;
        public removeRoadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wayType == "bus")
            {
                company.newBusRoads.Remove(comboBox1.SelectedItem as Road);
            }
            else if (wayType == "airplane")
            {
                company.newAirplaneRoads.Remove(comboBox1.SelectedItem as Road);
            }
            else if (wayType == "train")
            {
                company.newTrainRoads.Remove(comboBox1.SelectedItem as Road);
            }
            MessageBox.Show("Araç Başarıyla Silindi");
            this.Close();
        }

        private void removeRoadForm_Load(object sender, EventArgs e)
        {
            if(wayType== "bus") {
                foreach (Road b in company.newBusRoads)
                {
                    comboBox1.Items.Add(b);
                }
            }

            if (wayType == "train")
            {
                foreach (Road b in company.newTrainRoads)
                {
                    comboBox1.Items.Add(b);
                }
            }
            if (wayType == "airplane")
            {
                foreach (Road b in company.newAirplaneRoads)
                {
                    comboBox1.Items.Add(b);
                }
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
