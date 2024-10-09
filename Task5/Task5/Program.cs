using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1
			MyClass message = new MyClass();

			// 2
			intro Message = new intro();
			Message.introMessage("Razan");

			// 3
			Factorial testFac = new Factorial();
			testFac.CalculateFactorial(4);

			// 4
			Sort testSort = new Sort();
			testSort.sortArray(new[] { 11, -2, 4, 35, 0, 8, -9 });

			// 5
			DateTime date1 = new DateTime(1981, 11, 03);
			DateTime date2 = new DateTime(2013, 09, 04);

			string result = DateDifferenceCalculator.CalculateDifference(date1, date2);
			Console.WriteLine(result);

		}

		public class MyClass
		{
			public MyClass()
			{
				Console.WriteLine("MyClass class has initialized!");
			}
		}


		public class intro
		{
			public void introMessage(string name)
			{
                Console.WriteLine($"Hello All, I am {name}");
			}
		}

		public class Factorial
		{
			public void CalculateFactorial(int number)
			{
				int fac = 1;
				for (int i = 1; i <= number; i++)
				{
					fac *= i;
				}

				Console.WriteLine($"Factorial for the number {number} is {fac}");
			
			}
			
		}

		public class Sort
		{
			public void sortArray(int[] array) 
			{
				string result = "";
				Array.Sort(array);
                foreach (var item in array)
                {
					 result += item + " ";
                }
                Console.WriteLine(result);
			}
		}

		public class DateDifferenceCalculator
		{
			public static string CalculateDifference(DateTime date1, DateTime date2)
			{
				if (date2 < date1)
				{
					var temp = date1;
					date1 = date2;
					date2 = temp;
				}

				int years = date2.Year - date1.Year;

				int months = date2.Month - date1.Month;

				int days = date2.Day - date1.Day;

				if (days < 0)
				{
					months--;
					days += DateTime.DaysInMonth(date1.Year, date1.Month);
				}

				if (months < 0)
				{
					years--;
					months += 12;
				}
				return $"Difference: {years} years, {months} months, {days} days.";
			}
		}

	}
}
