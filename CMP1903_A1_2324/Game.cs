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
        private dynamic Roll_Dice() //creates a new die object and rolls it returning the value of the roll.
        {
            Die die = new Die();
            die.value = die.Roll();
            return die.value;
        }
        public int Return_Total(int num_of_dice) //sums the value of all dice rolls and returns the total. 
        {
            int total = 0;
            for ( int i = 0; i < num_of_dice; i++)
            {
                total = total + Roll_Dice();
            }
            return total;
        }
        private int Enter_Die() //asks for user input of how many dice need to be rolled
        {
            string s_amount;
            while (true)
            {
                Console.WriteLine("Enter the amount of dice you want");
                s_amount = Console.ReadLine();
                try
                {
                    int i_amount = Int32.Parse(s_amount);
                    return i_amount;
                }
                catch
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public int Run_Game() //runs all other game class methods in correct order
        {
            int amount = Enter_Die();
            int total = Return_Total(amount);
            return total;
        }
    }
}
