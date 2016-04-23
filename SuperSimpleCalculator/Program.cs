using System;

namespace SuperSimpleCalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Console.Write ("Enter the first number:");
			string firstNumberString = Console.ReadLine();
			int firstNumber = int.Parse (firstNumberString);

			Console.Write ("Enter the second number:");
			string secondNumberString = Console.ReadLine ();
			int secondNumber = int.Parse (secondNumberString);

			Console.Write ("Enter the operator (sum, difference, divide or multiply):");
			string operatorChoice = Console.ReadLine ();

			//operatorChoice = operatorChoice.ToLower;
			operatorChoice = operatorChoice.ToLower();
			int result = 0;
			if (operatorChoice == "sum") {
				int sum = firstNumber + secondNumber;
				result = sum;
			} else if (operatorChoice == "difference") {
				int diff = firstNumber - secondNumber;
				result = diff;
			} else if (operatorChoice == "divide") {
				int divide = firstNumber / secondNumber;
				result = divide;
			} else if (operatorChoice == "multiply") {
				int multiply = firstNumber * secondNumber;
				result = multiply;
			} else {
				Console.WriteLine ("Why didn't you pass any operators?");
			}
			Console.WriteLine ("The " + operatorChoice + " of " + firstNumber + " and " + secondNumber + " is " + result + ".");
		}
	}
}
