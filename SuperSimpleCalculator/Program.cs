using System;

namespace SuperSimpleCalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{



			Console.WriteLine ("Hello World!");

			//making the user to enter first number as a string and converting it into integer
			Console.Write ("Enter the first number:");
			string firstNumberString = Console.ReadLine();
			int firstNumber = int.Parse (firstNumberString);

			//making the user to enter second number as a string and converting it into integer
			Console.Write ("Enter the second number:");
			string secondNumberString = Console.ReadLine ();
			int secondNumber = int.Parse (secondNumberString);
		
			//similarly making the user to enter the operator choice
			Console.Write ("Enter the operator (sum, difference, divide or multiply):");
			string operatorChoice = Console.ReadLine ();

			//converting that user entered operator choice into lower case so that it will work even if user enters upper case letters
			operatorChoice = operatorChoice.ToLower();

			//checking for different operator choices
			int result = 0;
			if (operatorChoice == "sum" || operatorChoice == "+") {
				int sum = firstNumber + secondNumber;
				result = sum;
			} else if (operatorChoice == "difference" || operatorChoice == "-") {
				int diff = firstNumber - secondNumber;
				result = diff;
			} else if (operatorChoice == "divide" || operatorChoice == "/") {
				int divide = firstNumber / secondNumber;
				result = divide;
			} else if (operatorChoice == "multiply" || operatorChoice == "*") {
				int multiply = firstNumber * secondNumber;
				result = multiply;
			} else {
				Console.WriteLine ("Why didn't you pass any operators?");
			}

			Console.WriteLine ("The " + operatorChoice + " of " + firstNumber + " and " + secondNumber + " is " + result + ".");
		
			//asking user whether they want to check the greatest or smallest number of the series.
			Console.WriteLine ("Do you want to find the greatest and smallest number among other numbers (yes/no)?");
			string choice = Console.ReadLine ();
			choice = choice.ToLower ();
			if (choice == "yes") {

				Console.WriteLine ("How many numbers are there in the series?");
				string numberlistString = Console.ReadLine ();
				int numberList = int.Parse (numberlistString);

				//making the array of the size as given by the user
				int[] myArray = new int[numberList];
				for(int i = 0; i < myArray.Length; i++){

					Console.WriteLine ("Enter every numbers of the series one by one:");
					string numberString = Console.ReadLine ();
					int number = int.Parse (numberString);

					myArray [i] = number;
				}
				Console.WriteLine ("This is your list: ");
				Console.WriteLine(string.Join(", ", myArray));

				int greatestNumber = 0;
				int smallestNumber = int.MaxValue;

				//finding out the greatest and smallest numbers of the series
				foreach(int i in myArray){
					if(greatestNumber<i){
						greatestNumber = i;
					}
					if(smallestNumber>i){
						smallestNumber = i;
					}
				}

				//also finding out whether the smallest and greatest numbers are even or odd numbers
				string isEven = "even";
				string isOdd = "odd";
				string greatestNumberIs = "nothing";
				string smallestNumberIs = "nothig";

				if (greatestNumber % 2 == 0)
					greatestNumberIs = isEven;
				else
					greatestNumberIs = isOdd;

				if (smallestNumber % 2 == 0)
					smallestNumberIs = isEven;
				else
					smallestNumberIs = isOdd;
					

				Console.WriteLine ("The greatest number in the series is: " + greatestNumber + " and is " + greatestNumberIs);
				Console.WriteLine ("The smallest number in the series is: " + smallestNumber + " and is " + smallestNumberIs);

			} else {
				Console.WriteLine ("Ok! Have a great day!!");
			}

		
		}
	}
}
