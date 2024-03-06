using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private dynamic RollDice() //creates a new die object and rolls it returning the value of the roll.
        {
            Die die = new Die();
            die.value = die.Roll();
            return die.value;
        }
        public int ReturnTotal(int dieAmount) //sums the value of all dice rolls and returns the total. 
        {
            int total = 0;
            for ( int i = 0; i < dieAmount; i++)
            {
                total = total + RollDice();
            }
            return total;
        }
        private int EnterDie() //asks for user input of how many dice need to be rolled
        {
            string userInput;
            while (true)
            {
                Console.WriteLine("Enter the amount of dice you want");
                userInput = Console.ReadLine();
                try
                {
                    int dieAmount = Int32.Parse(userInput);
                    return dieAmount;
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public int RunGame() //runs all other game class methods in correct order
        {
            int amount = EnterDie();
            int total = ReturnTotal(amount);
            return total;
        }
    }
}
