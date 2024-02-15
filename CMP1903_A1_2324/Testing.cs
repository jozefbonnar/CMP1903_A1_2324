using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public Testing()
        {
            Console.WriteLine("Testing Class");
            Die die = new Die();
            int dieValue = die.Roll();
            Console.WriteLine("Die Value: " + dieValue);
            if (dieValue >= 1 && dieValue <= 6)
            {
                Console.WriteLine("Die Value is within range");
            }
            else
            {
                Console.WriteLine("Die Value is not within range");
            }
            Game game = new Game();
            Console.WriteLine("Total: " + game.Total());
            if (game.Total() >= 3 && game.Total() <= 18)
            {
                Console.WriteLine("Total is within range");
            }
            else
            {
                Console.WriteLine("Total is not within range");
            }
            //test

        }
    }
}
