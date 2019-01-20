using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionApp
{
    public class BankApp
    {
        public string account_nmuber;
        public string accoun_name;
        public double blance;

        public string Deposit(double amount)
        {
            blance += amount;
            return "Deposit";
        }

        public string Withdraw(double amount)
        {
           
            if(blance-amount >= 0)
            {
                blance -= amount;
                return "withdraw";
            }
            else
            {
                return "Not possible";
            }
            
        }
    }
}
