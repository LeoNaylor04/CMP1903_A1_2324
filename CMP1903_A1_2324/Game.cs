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
        public int Run_Game()
        {
            Die die1 = new Die();
            die1.value = die1.Roll();
            Die die2 = new Die();
            die2.value = die2.Roll();
            Die die3 = new Die();
            die3.value = die3.Roll();
            return die1.value + die2.value + die3.value;
        }

    }
}
