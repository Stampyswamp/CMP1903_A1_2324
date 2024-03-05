using System;
using System.Collections.Generic;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public void Gameloop()
        {

            //declare var
            var list = new List<int> { }; ///List is for calculating the sum.

            private static Die die = new Die();
            private static Testing debug = new Testing(); //Create Objects

            /*Rolls Dice
            Simple loop while roll the dice x amount of times, adding each roll to a list. */
            
            for (int i = 1; i < 4; i++)
            {
                int roll = die.Roll();
                Console.WriteLine($"Dice " + i + ": " + roll); // Roll Dice and report Value
                
                debug.Assert(roll);
                list.Add(roll); //check if the roll is the correct value, if so add to sum list. 
            }

            /*Print Sum
            Each diceroll in the list will be added to the sum.*/
            int sum = list.Sum(Convert.ToInt32());
            Console.WriteLine($"\nSum: {sum}");
            debug.Assert(sum);
        }
    }
}
