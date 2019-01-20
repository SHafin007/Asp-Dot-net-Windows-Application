using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTransactionApp
{
    public partial class Form1 : Form
    {
        private BankApp anAccount;
        public Form1()
        {
            InitializeComponent();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            anAccount = new BankApp();
            anAccount.account_nmuber = AccountNumberTextBox.Text;
            anAccount.accoun_name = AccountNameTextBox.Text;
            MessageBox.Show("Account Created");
        }

        private void Depositbutton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            if(anAccount != null)
            {
                string msgOut = anAccount.Deposit(amount);
                MessageBox.Show(msgOut);
            }
            else
            {
                MessageBox.Show("Please create an account");
            }
            
        }

        private void WithDrawbutton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountTextBox.Text);
            if (anAccount != null)
            {
                string msgOut = anAccount.Withdraw(amount);
                MessageBox.Show(msgOut);
            }
            else
            {
                MessageBox.Show("Please create an account");
            }
            
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            string msgOut = anAccount.accoun_name + ", Your Account Number :" + anAccount.account_nmuber + Environment.NewLine +
                                  "Your Deposit : " + anAccount.blance;
            MessageBox.Show(msgOut);
        }
    }
}
