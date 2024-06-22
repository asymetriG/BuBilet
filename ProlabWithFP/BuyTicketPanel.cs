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
    public partial class BuyTicketPanel : Form
    {
        public BuyTicketPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reklam rp = new Reklam();
            rp.Show();
            this.Hide();
        }

        private void BuyTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void BuyTicketPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
