using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
             
			Correct the syntax error:

			string [ ] ARR= [ 1,7  9  45, ]
			int arr2=["Str" "alex","moh"]
			string arr3= ['the','fox' ,'over', lazy, 'dog',  ] 

			What the index of "Banana","Tomato"?
			String [ ]  fruits=["Tomato","Banana","Watermelon"]
						// 1 for Banana, 0 for Tomato

			Create an multiple arrays that represents your:
			Favorite Food (5 items)
			Favorite Sport (3 items)
			Favorite Movie (4 items)
			Then, print each array using foreach, and Loop Through an Array
            */
			string[] favoriteFoods = { "Pizza", "Burger", "Pasta", "Fish", "Rice" };
			string[] favoriteSports = { "Running", "Basketball", "Tennis" };
			string[] favoriteMovies = { "Inception", "Interstellar", "Avatar", "Titanic" };

			foreach (var sport in favoriteSports)
			{
				Console.WriteLine(sport);
			}

			foreach (var food in favoriteFoods)
			{
				Console.WriteLine(food);
			}

			foreach (var movie in favoriteMovies)
			{
				Console.WriteLine(movie);
			}

			/*

			Write a program in C# to calculate the sum of three numbers with input in one line separated by a comma.
			Expected Output:
			Input three numbers separated by a comma: 5,10,15
			The sum of three numbers: 30.
			*/
			Console.Write("Input three numbers separated by comma: ");
			string[] inputs = Console.ReadLine().Split(',');
			double[] numbers = new double[inputs.Length];
			double total = 0;

			for (int i = 0; i < inputs.Length; i++)
			{
				numbers[i] = double.Parse(inputs[i]);
			}

			foreach (var number in numbers)
			{
				total += number;
			}

			Console.WriteLine($"The sum of three numbers: {total}");

			/*
			Write a program in C# to display the n terms of odd numbers and their sum from [1- 100]. 
			Test Data:
			The odd numbers are: 1 3 5 7 9 11 13 15 17 19……
			The Sum of odd Numbers is: …...
            */
			int current = 1;
			int oddSum = 0;

			Console.WriteLine("The odd numbers are:");
			while (current <= 100)
			{
				if (current % 2 != 0)
				{
					Console.Write(current + " ");
					oddSum += current;
				}
				current++;
			}
			Console.WriteLine($"\nThe Sum of odd Numbers is: {oddSum}");

			/*

			Write a program in C# to display the pattern like a right-angle triangle using an asterisk. Go to the editor
			The pattern like:
			   *
			  **
			 ***
			 *
			*/
			int height = 3;
			for (int i = 1; i <= height; i++)
			{
				for (int j = 1; j <= height - i; j++)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= i; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			/*

			Write a program in C# to make such a pattern like a right-angle triangle
			with numbers increased by 1. Go to the editor
			The pattern like :

               1
              2 3
             4 5 6
           7 8 9 10 

            */

			int rows = 4;
			int currentNumber = 1;

			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= rows - i; j++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write(currentNumber++ + " ");
				}

				Console.WriteLine();
			}
		}
	}
}
