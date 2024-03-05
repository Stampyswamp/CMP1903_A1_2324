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
        
            Testing debug = new Testing(); //Create Object
        
            /*Rolls Dice
            Simple loop while roll the dice x amount of times, adding each roll to a list. */
        
            for (int i = 1; i< 4; i++)
            {
                Die die = new Die();
                int roll = die.Roll();
                System.Threading.Thread.Sleep(roll);  //Creates Die Object. Rolls Dice. Waits 1-6ms.
        
                Console.WriteLine($"Dice " + i + ": " + roll); // Roll Dice and report Value
        
                debug.Assert(roll,3);
                list.Add(roll); //check if the roll is the correct value, if so add to sum list. 
            }
        
            /*Print Sum
            Each diceroll in the list will be added to the sum.*/
            int sum = list.Sum();
            Console.WriteLine($"\nSum: {sum}");
            debug.Assert(3,sum);
        }
    }
}
