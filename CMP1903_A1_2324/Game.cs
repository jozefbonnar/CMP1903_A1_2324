using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private List<Die> dice; // List to hold the dice objects

        /// <summary>
        /// Constructor for the game class
        /// It initialises the list of dice and adds three die's to the list
        /// </summary>
        public Game()
        {
            dice = new List<Die>(); // Initialize the list of dice
            for (int i = 0; i < 3; i++)
            {
                dice.Add(new Die()); // Add three dice to the list
            }
        }

        /// <summary>
        /// Method to roll the dice and return the values of the dice
        /// </summary>
        /// <returns>An array containing the values of the rolled dice</returns>
        public int[] GetDieRolls()
        {
            int[] diceValues = new int[3];
            Console.Write("You rolled a: ");
            foreach (var die in dice)
            {
                int index = dice.IndexOf(die);
                diceValues[index] = die.RollDie();
                Console.Write(diceValues[index] + ", ");
            }
            return diceValues;
        }

        /// <summary>
        /// It will take an array of integers and return the sum of the integers
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        public int Total(int[] ints)
        {
            return ints.Sum();
        }

        /// <summary>
        /// It rolls the dice, calculates the sum of the dice and also the statistics of the rolls
        /// </summary>
        /// <param name="testingMode"></param>
        /// <returns>An array containing the statistics of the rolls so far</returns>
        public int[] RollDiceAndSum(int testingMode = 0)
        {
            int[] statistics = new int[6];
            string input = "";

            while (input != "exit")
            {
                //roll the dices and put the statistics in the array and also get the total
                int[] diceValues = GetDieRolls();
                foreach (var value in diceValues)
                {
                    statistics[value - 1]++;
                }

                int total = Total(diceValues);

                Console.WriteLine();
                Console.WriteLine("The total of the three dice rolls is: " + total);
                Console.WriteLine("Press enter to roll again or type exit to stop");
                if (testingMode == 1)
                {
                    break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine("Statistics of the rolls:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Number of " + (i + 1) + "'s: " + statistics[i]);
            }
            return statistics;

        }
    }
}
