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
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        /// <summary>
        /// Constructor for the Testing class
        /// It tests the game and die classes and compares the outputs to expected ones
        /// </summary>
        public Testing()
        {
            Console.WriteLine("-----------------------------\nTesting the Game and Die classes\n");
            TestDieRoll();
            TestGameRollDice();
            TestStatistics();
            Console.Write("Test complete. Press enter to exit.");
            Console.ReadLine();
        }

        /// <summary>
        /// Test the Die class
        /// </summary>
        private void TestDieRoll()
        {
            Console.WriteLine("Testing the Die class");
            Die die = new Die();
            int[] results = new int[50]; // Roll the die 50 times
            Console.Write("Rolling the dice 50 times: ");
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = die.RollDie();
                Debug.Assert(results[i] >= 1 && results[i] <= 6, "The result of the die roll is not between 1 and 6");
                Console.Write(results[i]+", ");
            }
            Console.WriteLine("\nTest Passed: The results of the die rolls are between 1 and 6");
        }

        /// <summary>
        /// Test the Game class Roll Dice method
        /// </summary>
        private void TestGameRollDice()
        {
            Console.WriteLine("Testing the Game class: Dice Roll");
            Game game = new Game();
            int[] result = game.GetDieRolls();
            Debug.Assert(result.Length == 3, "The length of the result array is not 3");
            Console.WriteLine("The length of the result array is: " + result.Length);
            if (result.Length == 3)
            {
                Console.WriteLine("Test Passed: The length of the result array is 3");
            }
            else
            {
                Console.WriteLine("Test Failed: The length of the result array is not 3");
            }
        }

        /// <summary>
        /// Test the Game class statistics method
        /// </summary>
        private void TestStatistics()
        {
            Console.WriteLine("Testing the Game class: Roll Dice And Sum");
            Game game = new Game();
            int[] result = game.RollDiceAndSum(1);

            Debug.Assert(result.Length == 6, "The length of the result array is not 6");
            Console.WriteLine("The length of the result array is: " + result.Length);
            if (result.Length == 6)
            {
                Console.WriteLine("Test Passed: The length of the result array is 6");
            }
            else
            {
                Console.WriteLine("Test Failed: The length of the result array is not 6");
            }
        }
    }
}
