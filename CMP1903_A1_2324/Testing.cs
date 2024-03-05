using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void Game_Test(Game my_game) // Tests the output for the return total game class method for function
        {
            Debug.Assert(my_game != null);
            int n = 5;
            Debug.Assert(my_game.Return_Total(n)<=6*n && my_game.Return_Total(n)>=n);
        }
        public void Die_Test(Die my_die) // Tests the Die roll function and makes sure the object properties are stored properly
        {
            Debug.Assert(my_die != null);
            Debug.Assert(my_die.Roll()>=1 && my_die.Roll()<=6);
            my_die.value=my_die.Roll();
            Debug.Assert(my_die.value <= 6 && my_die.value >= 1);
        }
    }
}
