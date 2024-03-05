using System;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /// <summary>
        /// Checks if the roll is between 1-6, or if the sum is between 3-18.
        /// </summary>
        /// <param name="roll", name="sum"></param>
        /// <returns> Writes in the console if the role is legal, else returns true/false incase you want to do something with this in the future. as no errors are raised. </returns>
        public bool Assert(int roll = 3, int sum = 5)
        {
            Debug.Assert(roll >= 1 && roll <= 6, "Number is not between 1 and 6")

            Debug.Assert(sum >= 3 && sum <= 18, "sum is not between 3 and 18")
        }
      
     
    }
}
