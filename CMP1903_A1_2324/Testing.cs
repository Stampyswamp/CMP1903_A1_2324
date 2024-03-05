using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
         /// <summary>
         /// Checks if the roll is between 1-6, or if the sum is between 3-18.
         /// </summary>
         /// <param name="roll", name="sum"></param>
         /// <returns> IN DEBUG MODE. will return if the roll or sum is invalid. and end code. </returns>
         public void Assert(int roll, int sum)
         {
             Debug.Assert(roll >= 1 && roll <= 6, "Roll is not between 1 and 6");
        
             //Method
             Debug.Assert(sum >= 3 && sum <= 18, "Sum is not between 3 and 18");
         }
    }
}
