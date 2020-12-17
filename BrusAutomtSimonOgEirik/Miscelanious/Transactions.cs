using System;
using System.Collections.Generic;
using System.Text;

namespace BrusAutomatSimonOgEirik
{
    class Transactions
    {
        protected double Balance;

        public void InsertCoins(int amount)
        {
            Balance += amount;
        }

        public void ReturnCoins()
        {
            Console.WriteLine($"{Balance} coins was blurted out\n\n");
            Balance -= Balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Current balance is {Balance}");
        }

        public void DeductPrice(double price)
        {
            if (Balance >= price) Balance -= price;
        }
    }
}
