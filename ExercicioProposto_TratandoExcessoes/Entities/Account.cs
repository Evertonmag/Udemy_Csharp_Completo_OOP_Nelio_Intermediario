using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto_TratandoExcessoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double balance)
        {
            Balance += balance;
        }
        
        public void Withdraw(double withdraw)
        {
            if (withdraw > WithDrawLimit)
            {
                throw new Exception("The amount exceeds withdraw limit");
            }
            if (withdraw > Balance)
            {
                throw new Exception("Not enough balance");
            }


            Balance -= withdraw;
        }

        
    }
}
