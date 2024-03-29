﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private List<Die> _dice; // List to hold the dice objects

        /// <summary>
        /// Constructor for the game class
        /// It initialises the list of dice and adds three die's to the list
        /// </summary>
        public Game()
        {
            _dice = new List<Die>(); // Initialize the list of dice
            for (int i = 0; i < 3; i++)
            {
                _dice.Add(new Die()); // Add three dice to the list
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
            foreach (var die in _dice)
            {
                int index = _dice.IndexOf(die);
                diceValues[index] = die.RollDie();
                Console.Write(diceValues[index] + ", ");
            }
            return diceValues;
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
            int totalRolls = 1; // Counter for total rolls
            int totalSum = 0; // Counter for total sum of all rolls

            while (input != "exit")
            {
                //roll the dices and put the statistics in the array and also get the total
                int[] diceValues = GetDieRolls();
                foreach (var value in diceValues)
                {
                    statistics[value - 1]++;
                }

                int total = diceValues.Sum(); //sum the values of the dice
                totalSum += total; //add the total of this roll to the total sum

                Console.WriteLine();
                Console.WriteLine("The total of the three dice rolls is: " + total);
                Console.WriteLine("Press enter to roll again or type exit to stop");
                if (testingMode == 1)
                {
                    break;
                }
                input = Console.ReadLine();
                totalRolls++; // Increment the counter after each roll
            }
            Console.WriteLine("Statistics of the rolls:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Number of " + (i + 1) + "'s: " + statistics[i]);
            }
            Console.WriteLine("Total number of rolls: " + totalRolls); // Print the total number of rolls
            Console.WriteLine("Total sum of all rolls: " + totalSum); // Print the total sum of all rolls
            return statistics;
        }
    }
}
