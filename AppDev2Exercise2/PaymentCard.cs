using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev2Exercise2
{
    public class PaymentCard
    {
        private double balance;
        double lunch = 10.60;
        double coffee = 2.6;

        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }

        public override string ToString()
        {
            return $"The card has a balance of {balance} euros";
        }

        public void EatLunch()
        {
            if (balance >= lunch)
            {
                balance -= lunch;
            }
        }

        public void DrinkCoffee()
        {
            if (balance >= coffee) 
            {
                balance -= coffee;
            }
        }

        public void AddMoney(double amount)
        {
            balance += amount;
        }

    }

}
