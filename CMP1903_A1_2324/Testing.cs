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
            TestGameTotal();
            TestStatistics();
            Console.ReadLine();
        }

        /// <summary>
        /// Test the Die class
        /// </summary>
        private void TestDieRoll()
        {
            Console.WriteLine("Testing the Die class");
            Die die = new Die();
            int result = die.RollDie();
            Debug.Assert(result >= 1 && result <= 6, "The result of the die roll is not between 1 and 6");
            Console.WriteLine("The result of the die roll is: " + result);
            if (result >= 1 && result <= 6)
            {
                Console.WriteLine("Test Passed: The result of the die roll is between 1 and 6");
            }
            else
            {
                Console.WriteLine("Test Failed: The result of the die roll is not between 1 and 6");
            }
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
        /// Test the Game class Total method
        /// </summary>
        private void TestGameTotal()
        {
            Console.WriteLine("Testing the Game class: Total");
            Game game = new Game();
            int[] TestData = new int[] { 1, 2, 3 };
            int result = game.Total(TestData);
            Debug.Assert(result == 6, "The total of the array is not 6");
            Console.WriteLine("The total of the array is: " + result);
            if (result == 6)
            {
                Console.WriteLine("Test Passed: The total of the array is 6");
            }
            else
            {
                Console.WriteLine("Test Failed: The total of the array is not 6");
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
