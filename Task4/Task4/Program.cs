using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//QuestionTwo(5);
			//QuestionThree(new []{1200,1000,1999, 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 } );
			//QuestionFour(2);
			//QuestionFive(2,3,5);
			//QuestionSix("mohammd", new[] { "razan", "ahmad" });
			//QuestionEight(1900);
			//Console.WriteLine(QuestionNine(3));
			//QuestionTen("one two four");
		}


		static void QuestionOne()
		{
			int sum = 0;
			for (int i = 1; i <= 10; i++)
			{
				Console.Write("Number " + i + ":");
				int num = int.Parse(Console.ReadLine());
				sum += num;
			}
			Console.WriteLine("The sum is: " + sum + " ,and the average is: " + (sum / 10));
		}

		static void QuestionTwo(int limit)
		{
            for (int i = 1; i <= limit; i++)
            {
				Console.WriteLine("Number is: " + i + "and cube of the " + i + "is : "+ (i*i*i) );
            }
        }

		static void QuestionThree(int[] years)
		{
			List<int> filteredYears = new List<int>();
            for (int i = 0; i < years.Length; i++)
            {
				if (years[i] >= 1950)
				{
					filteredYears.Add(years[i]);
				}
				
            }
			foreach (int year in filteredYears)
			{
				Console.WriteLine(year);
			}
		}
		static void QuestionFour(int years)
		{
            Console.WriteLine("Age in Days is: " + years*365);
		}

		static void QuestionFive(int chickensNum , int dogNum , int cowsNum)
		{
			Console.WriteLine("Number of all animal's legs : " + (chickensNum * 2 + dogNum * 4 + cowsNum * 4));
		}

		static void QuestionSix(string userName , string[] users)
		{
            for (int i = 0; i < users.Length; i++)
            {
				if (users[i].Equals(userName))
				{
					Console.WriteLine(users[i] + " Pass");
					break;
				}
				else
				{
					Console.WriteLine(users[i] + " Faild");
					break;
				}
            }
        }

		static void QuestionSeven(int num)
		{
            Console.WriteLine(num*num);
		}
		static void QuestionEight(int year)
		{
			if (year >= 1900 && year <= 2024)
			{
				if (year % 4 == 0 && year %100 != 0 || year%400 == 0)
				{
					Console.WriteLine("The year " + year + " is a leap year");
				}
				else
				{
					Console.WriteLine("The year " + year + " is not a leap year");

				}
			}
			else
			{
				Console.WriteLine("Please enter a vaild year");
			}

		}

		static bool QuestionNine(int num)
		{
			if (num <= 1)
				return false;

			for (int i = 2; i <= Math.Sqrt(num); i++)
			{
				if (num % i == 0)
					return false;
			}

			return true;
		}

		static void QuestionTen(string str)
		{
			string[] words = str.Split(' ');
            Console.WriteLine(words.Length);
		}

	}
}
