﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game new_game = new Game(); // creates a game object
            Console.WriteLine(new_game.Run_Game()); // runs all methods in the game class throught the run_game method
        }
    }
    //extra comment
}
