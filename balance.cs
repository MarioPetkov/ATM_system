using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_system
{
    public partial class Balance : Form
    {
        private readonly decimal bal;
        private Services servicesForm;


        // Constructor to receive and display Balance
        public Balance(Services servicesForm, decimal bal)
        {
            InitializeComponent();
            this.servicesForm = servicesForm;
            this.bal = bal;
       
        }

        private void balance_Load(object sender, EventArgs e)
        {
            lbl_balance.Text = $"Current Balance: " + bal.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Services servicesForm = new Services();
            servicesForm.Show();
            this.Hide();
        }
    }
}
