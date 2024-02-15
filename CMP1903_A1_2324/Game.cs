using System;
using System.Collections.Generic;
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
         * the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public int Total()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            int total = die1.Roll() + die2.Roll() + die3.Roll();
            return total;
        }








    }
}
