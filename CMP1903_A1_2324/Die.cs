using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property

        /// <summary>
        /// Constructor for the Die class
        /// It will call the RollDie method to roll the die
        /// </summary>
        public Die() 
        {
            RollDie();
        } //Constructor to create a new Die object
        public int DieValue { get; private set; } //Property to hold the current die value
        private static Random rnd = new Random(); //Random object to generate random numbers
        //Method

        /// <summary>
        /// Roll the die and return the value of the die
        /// </summary>
        /// <returns>The value of the rolled die from random</returns>
        public int RollDie() //Method to roll the die taking no parameters and returning an integer
        {
            //roll the die and set the DieValue property to the result
            DieValue = rnd.Next(1, 7);
            return DieValue;
        }

    }
}
