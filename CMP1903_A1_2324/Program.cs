using System;
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
            Game new_game = new Game(); // creates a game object
            Console.WriteLine(new_game.Run_Game()); // runs all methods in the game class throught the run_game method
            Testing my_tests = new Testing();
            my_tests.Game_Test(new_game);
            Die testing_die = new Die();
            my_tests.Die_Test(testing_die);
        }
    }
}
