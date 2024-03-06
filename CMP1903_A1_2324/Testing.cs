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
        public void GameTest(Game myGame) // Tests the output for the return total game class method for function
        {
            Debug.Assert(myGame != null);
            int n = 5;
            Debug.Assert(myGame.ReturnTotal(n)<=6*n && myGame.ReturnTotal(n)>=n);
        }
        public void DieTest(Die myDie) // Tests the Die roll function and makes sure the object properties are stored properly
        {
            Debug.Assert(myDie != null);
            Debug.Assert(myDie.Roll()>=1 && myDie.Roll()<=6);
            myDie.value=myDie.Roll();
            Debug.Assert(myDie.value <= 6 && myDie.value >= 1);
        }
    }
}
