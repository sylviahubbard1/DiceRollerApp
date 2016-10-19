
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerApp
{
    public class DiceRoll
    {
        public void messageDice(int d1, int d2)
        {
            if (d1 == 6 && d2 == 6)

            {
                Console.WriteLine("Box Cars");
            }
            else if (d1 == 1 && d2 == 1)
            {
                Console.WriteLine("Snake Eyes");
            }
            else if (d1 == 2 && d2 == 3)
            {
                Console.WriteLine("CRAPS");
            }
            else if (d2 == 2 && d1 == 3)
            {
                Console.WriteLine("CRAPS");
            }

        }
    }
}