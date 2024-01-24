using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wager
{
    internal class Wager
    {
        public required string Name;
        public int Cash;

        /// <summary>
        /// WriteMyInfo() writes the  Players Name and amount of players Cash balance to console
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} has {Cash} bucks.");
        }

        /// <summary>
        /// This takes the wager amount and verifies if the wager is valid (amount > 0) 
        /// then if wager amount is greater then plays Cash balance
        /// if both tests pass subtract amount of wager from the cash balance
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"The dealer says: {amount} isn't valid amount");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} says: I don't have enough cash to give you {amount}");
                Console.WriteLine("The dealer says GO TO THE BACKROOM!");
                return 0;
            }
            Console.WriteLine($"Bad Luck You loose");
            Cash -= amount;
            return amount;
        }

        /// <summary>
        /// Update players Cash variable with the winning pot
        /// </summary>
        /// <param name="amount"></param>
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"The Dealer says: {amount} isn't an amount I'll take");
            }
            else
            {
                
                Cash += amount;
            }

        }
    }
}
