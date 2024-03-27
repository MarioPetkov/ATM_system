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

    public partial class Withdraw : Form
    {
        private decimal bal;
        private Services servicesForm;
        public Withdraw(Services servicesForm, decimal bal)
        {
            InitializeComponent();
            this.servicesForm = servicesForm;
            this.bal = bal;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            servicesForm.Show();
            this.Hide();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(tb_Withdraw.Text, out amount))
            {
                if (amount <= bal)
                {
                    bal -= amount;
                    MessageBox.Show(this, $"Withdraw successful. Your new Balance is: " + bal.ToString() + " EUR");
                    servicesForm.UpdateBalance(bal);
                }
                else
                {
                    MessageBox.Show("Insufficient funds.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
