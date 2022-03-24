using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTask
{
    public static class CalculationHelper
    {
        public static int ExecuteArrayFunction(int[] arrayvalues)
        {
			//int[] Arrayvalues = { 8, 8 }; //Array elements
			var score = 0;
			foreach (var n in arrayvalues) // loop the array to get each element
			{

				if (n % 2 == 0) // Checking if element is an EVEN NUMBER 
				{
					score = score + 1;
				}
				if (n % 2 != 0) // Checking if element is an ODD NUMBER 
				{
					score = score + 3;
				}
				 if (n == 8) // Checking if element is 8
				{
					score += 5;
				}
			};
			return score;	
		}

	 
	}
}
