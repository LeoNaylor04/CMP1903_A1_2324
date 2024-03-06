using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int _value = 0; // encapsulated die value
        public int value // die value able to be used by rest of program, modifying the encapsulatd value
        {
            get { return _value; }
            set { _value = value; }
        }
        public int Roll() // returns random number between 1 and 6 inclusive
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
