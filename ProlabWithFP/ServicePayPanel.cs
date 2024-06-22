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
    public partial class ServicePayPanel : Form
    {
        public ServicePayPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            payText.Text +="1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payText.Text +="2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payText.Text +="3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            payText.Text +="4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            payText.Text +="5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            payText.Text +="6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            payText.Text +="7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            payText.Text +="8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            payText.Text +="9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            payText.Text +="0";
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                AdminPanel.pay = int.Parse(payText.Text);
            }
            catch (Exception)
            {

                this.Close();
            }
            

            this.Close();
        }

        private void ServicePayPanel_Load(object sender, EventArgs e)
        {
            payText.Text = "";
        }

        private void backSlash_Click(object sender, EventArgs e)
        {
            try
            {
                string stringWithoutLastChar = payText.Text.Substring(0, payText.Text.Length - 1);
                payText.Text = stringWithoutLastChar;
            }
            catch (Exception)
            {
                payText.Text = "";
            }
            

            
        }
    }
}
