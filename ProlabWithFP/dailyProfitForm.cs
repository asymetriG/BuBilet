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
    public partial class dailyProfitForm : Form
    {
        public Company company;
        public int dailycost = 0;
        public dailyProfitForm()
        {
            InitializeComponent();
        }

        public void reload()
        {
            string day = "";
            

            if(comboBox1.SelectedIndex == 0)
            {
                day = "4 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                day = "5 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                day = "6 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                day = "7 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                day = "8 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                day = "9 Aralık 2023";
            }
            if (comboBox1.SelectedIndex == 6)
            {
                day = "10 Aralık 2023";
            }
            dailyCost.Text = dailycost.ToString();
            int dailyincome = 0;

            foreach(Transport ts in company.currentTickets)
            {
                if(ts.day==day)
                {
                    foreach(Passenger p in ts.customer.passengers)
                    {
                        dailyincome += p.res.price;
                    }
                }
            }
            dailyIncome.Text = dailyincome.ToString();

            if(dailyincome - dailycost < 0)
            {
                dailyProfit.Text = (dailyincome - dailycost)*-1 + " TL Zarar";
            }
            else
            {
                dailyProfit.Text = (dailyincome - dailycost) + " TL Kar";
            }

        }

        private void dailyProfitForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salı");
            comboBox1.Items.Add("Çarşamba");
            comboBox1.Items.Add("Perşembe");
            comboBox1.Items.Add("Cuma");
            comboBox1.Items.Add("Cumartesi");
            comboBox1.Items.Add("Pazar");

            comboBox1.SelectedIndex = 0;

            this.reload();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.reload();
        }
    }
}
