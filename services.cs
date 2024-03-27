using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ATM_system
{
    public partial class Services : Form
    {

        private decimal bal = 1000;

        public Services()
        {
            InitializeComponent();
        }

        private void btn_language_Click(object sender, EventArgs e)
        {
            var languageForm = new Language_form(this);
            languageForm.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            var WithdrawForm = new Withdraw(this, bal);
            WithdrawForm.Show();
            this.Hide();

        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            
            var balanceForm = new Balance(this, bal);
            balanceForm.Show();
            this.Hide();
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            var depositForm = new Deposit(this, bal);
            depositForm.Show();
            this.Hide();
        }

        public void UpdateBalance(decimal newBalance)
        {
            bal = newBalance;
        }

        public decimal GetBalance()
        {
            return bal;
        }
    }
}
