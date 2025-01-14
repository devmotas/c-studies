using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        private double _amount;

        public int Id { get; }
        public string Name { get; set; }

        public Account(int id, string name, double amount)
        {
            Id = id;
            Name = name;
            _amount = 0.0;

            if (amount > 0)
            {
                AddMoney(amount);
            }
        }


        public void AddMoney(double amount)
        {
            _amount += amount;

        }

        public void RmMoney(double amount)
        {
            _amount -= (amount + 5.00);
        }


        public override string ToString()
        {
            return $"Conta: {Id}, Titular: {Name}, Saldo: $ {_amount.ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
