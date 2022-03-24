using ArrayTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise53
{

	public static void Main()
	{

		int[] exercise1 = { 1, 2, 3, 4, 5 };
		int[] exercise2 = { 15,25,35 };
		int[] exercise3 = { 8,8};

		 int score1 = CalculationHelper.ExecuteArrayFunction(exercise1);
		 int score2 = CalculationHelper.ExecuteArrayFunction(exercise2);
		 int score3 = CalculationHelper.ExecuteArrayFunction(exercise3);

		Console.WriteLine(" ");
		Console.WriteLine("Exercise1 Data: [{0}], Exercise1 result: {1} ",string.Join(",", exercise1), score1);
		Console.WriteLine("--------------------------------------------------------------");
		Console.WriteLine(" ");

		Console.WriteLine("Exercise2 Data: [{0}], Exercise1 result: {1} ", string.Join(",", exercise2), score2);
		Console.WriteLine("--------------------------------------------------------------");
		Console.WriteLine(" ");

		Console.WriteLine("Exercise3 Data: [{0}], Exercise1 result: {1} ", string.Join(",", exercise3), score3);
		Console.WriteLine("--------------------------------------------------------------");
		Console.ReadLine();
	}
}