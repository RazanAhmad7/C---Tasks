using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Uncomment to run different tasks
			// QuestionsOne();
			// QuestionsTwo();
			// QuestionsThree();
			// QuestionsFour();
			// QuestionsFive();
			// QuestionsSix();
			// QuestionsSeven();
			// QuestionsEight();
			// QuestionsNine("first ssff");
		}

		static void QuestionsOne()
		{
			Console.WriteLine("Please input two integers for addition:");
			int firstNumber = int.Parse(Console.ReadLine());
			int secondNumber = int.Parse(Console.ReadLine());
			Console.WriteLine($"The total is: {firstNumber + secondNumber}");
		}

		static void QuestionsTwo()
		{
			Console.WriteLine("Enter a number to check its sign:");
			int inputNumber = int.Parse(Console.ReadLine());
			Console.WriteLine(inputNumber < 0 ? "The sign is: -" : "The sign is: +");
		}

		static void QuestionsThree()
		{
			List<int> userNumbers = new List<int>();

			while (true)
			{
				Console.WriteLine("Input a number (or -1 to stop):");
				int userInput = int.Parse(Console.ReadLine());
				if (userInput != -1)
				{
					userNumbers.Add(userInput);
				}
				else
				{
					break;
				}
			}

			userNumbers.Sort();
			userNumbers.Reverse();
			Console.WriteLine("Sorted numbers in descending order:");
			foreach (var number in userNumbers)
			{
				Console.WriteLine(number);
			}
		}

		static void QuestionsFour()
		{
			int[] sampleNumbers = { 1, 4, 6, 8, 3 };
			int maximumValue = sampleNumbers.Max();
			Console.WriteLine($"The maximum number is: {maximumValue}");
		}

		static void QuestionsFive()
		{
			Console.WriteLine("Enter distance in kilometers:");
			double kilometers = double.Parse(Console.ReadLine());
			Console.WriteLine($"Distance in miles: {kilometers * 0.621371}");
		}

		static void QuestionsSix()
		{
			Console.WriteLine("Input hours:");
			double hours = double.Parse(Console.ReadLine());
			Console.WriteLine("Input minutes:");
			double minutes = double.Parse(Console.ReadLine());
			Console.WriteLine($"Total time in minutes: {hours * 60 + minutes}");
		}

		static void QuestionsSeven()
		{
			Console.WriteLine("Enter total minutes:");
			double totalMinutes = double.Parse(Console.ReadLine());
			double hours = Math.Floor(totalMinutes / 60);
			double minutes = totalMinutes % 60;

			Console.WriteLine($"{hours} hour(s), {minutes} minute(s)");
		}

		static void QuestionsEight()
		{
			string[] exampleSentences = {
				"Here is the first sentence.",
				"This is the second sentence.",
				"The third sentence is here.",
				"Here is the fourth .",
				"the fifth sentence"
			};

			foreach (var sentence in exampleSentences)
			{
				Console.WriteLine($"Sentence: {sentence}\nLength: {sentence.Length}");
			}
		}

		static void QuestionsNine(string input)
		{
			string[] words = input.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Length % 2 != 0)
				{
					words[i] = new string(words[i].Reverse().ToArray());
				}
			}

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}
	}
}

