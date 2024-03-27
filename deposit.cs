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
    public partial class Deposit : Form
    {
        private decimal bal;
        private Services servicesForm;

        public Deposit(Services servicesForm, decimal bal)
        {
            InitializeComponent();
            this.servicesForm = servicesForm;
            this.bal = bal;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            servicesForm.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(tb_balance.Text, out amount))
            {
                bal += amount;
                MessageBox.Show(this, $"Deposit successful. Your new Balance is: " + bal.ToString() + " EUR");
                servicesForm.UpdateBalance(bal);
            }
            else
            {
                MessageBox.Show(this, "Invalid amount.");
            }
        }


        private void tb_balance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
