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
            Game newGame = new Game(); // creates a game object
            Console.WriteLine(newGame.RunGame()); // runs all methods in the game class throught the run_game method
            Testing myTests = new Testing(); // creates a testing object for testing the game and die objects
            myTests.GameTest(newGame); // tests the game object
            Die testingDie = new Die(); // creates a die object for testing
            myTests.DieTest(testingDie); // tests the die object
        }
    }
}
