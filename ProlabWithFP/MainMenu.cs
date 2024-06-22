using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ProlabWithFP
{
    public partial class MainMenu : Form
    {
        private Button[] buttons; 
        private System.Windows.Forms.Timer[] timers; 
        private int[] opacities;  
        private const int animationDuration = 10000;

        public MainMenu()
        {
            InitializeComponent();
            Load += MainMenu_Load;
            buttons = new Button[] { adminButton, firmButton, userButton };
            timers = new System.Windows.Forms.Timer[buttons.Length];
            opacities = new int[buttons.Length];
        }
        private async void MainMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                opacities[i] = 0;
                buttons[i].BackColor = Color.White;

                timers[i] = new System.Windows.Forms.Timer();
                timers[i].Interval = animationDuration / 100;
                timers[i].Tag = i;
                timers[i].Tick += Timer_Tick;
                timers[i].Start();
            }



        }
         private void Timer_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = (System.Windows.Forms.Timer)sender;
            int index = (int)timer.Tag;

            opacities[index]++;

            if (opacities[index] <= 100)
            {
                buttons[index].Visible = true; 
                buttons[index].BackColor = Color.FromArgb((int)(opacities[index] * 255 / 100), Color.Gray);
            }
            else
            {
                opacities[index] = 100;
                timers[index].Stop();
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.fromWhere = "admin";
            lf.Show();
            this.Hide();
        }

        private void firmButton_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.fromWhere = "firm";
            lf.Show();
            this.Hide();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            BuyTicketPanel bt = new BuyTicketPanel();
            bt.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
