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
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        private int Roll_Dice()
        {
            Die die = new Die();
            die.value = die.Roll();
            return die.value;
        }
        private int Return_Total(int num_of_dice)
        {
            int total = 0;
            for ( int i = 0; i < num_of_dice; i++)
            {
                total = total + Roll_Dice();
            }
            return total;
        }
        private int Enter_Die()
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
        public int Run_Game()
        {
            int amount = Enter_Die();
            int total = Return_Total(amount);
            return total;
        }
    }
}
