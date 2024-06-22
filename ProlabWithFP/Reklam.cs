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
    public partial class Reklam : Form
    {
        public Reklam()
        {
            InitializeComponent();
        }

        private void Reklam_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserPanel up = new UserPanel();
            up.Show();
            this.Hide();
        }

        private void Reklam_Load(object sender, EventArgs e)
        {

        }
    }
}
