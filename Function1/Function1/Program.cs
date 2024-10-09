using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			convertToSeconds(2);
			evenNumberEvenIndex(new[] { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 });
			evenIndexOddLength(new[] { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" });
			powerElementIndex(new[] { 44, 5, 4, 3, 2, 10 });
			Console.WriteLine(multiplication2(5, 4));
            Console.WriteLine(muti2(6, 3));
		}

		// 1
		public static void convertToSeconds(int minutes) 
		{
			int seconds = minutes * 60;
            Console.WriteLine($"{minutes} Minutes is {seconds} Seconds!");
		}

		// 2
		public static int IncrementNumber(int number)
		{
			return number + 1;
		}

		// 3
		public void FirstElement(int[] numbers)
		{
			if (numbers.Length > 0)
			{
				Console.WriteLine($"First Element is : {numbers[0]}") ;
			}
			else
			{
                Console.WriteLine("The array is empty.");
			}
		}
		// 4
		public double TriangleArea(double length, double height)
		{
			return (length * height) / 2;
		}
		// 5
		public static int[] evenNumberEvenIndex(int[] numbers)
		{
			
			List<int> evenNumbers = new List<int>() ;
			if (numbers.Length > 0) 
			{
				for (int i = 0; i < numbers.Length; i = i +2 ) 
				{
					if (numbers[i]%2 == 0)
					{
						evenNumbers.Add(numbers[i]);
					}
				}
			}
			
			return evenNumbers.ToArray();
        }

		// 6
		public static string[] evenIndexOddLength(string[] strings)
		{

			List<string> oddLength = new List<string>();
			if (strings.Length > 0)
			{
				for (int i = 0; i < strings.Length; i = i + 2)
				{
					if (strings[i].Length % 2 != 0)
					{
						oddLength.Add(strings[i]);
					}
				}
			}
			
			return oddLength.ToArray();
		}

		// 7
		public static double[] powerElementIndex (int[] numbers)
		{
			List<double> powered = new List<double>();
			if (numbers.Length > 0)
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					powered.Add(Math.Pow(numbers[i],i));
				}
			}
			

			return powered.ToArray();
		}

		// 8

		public static int multiplication2(int a, int b)
		{
			int result = 0;

			for (int i = 0; i < b; i++)
			{
				result += a;
			}

			return result;
		}

		// 9

		public static int muti2(int a, int b)
		{
			int result = 1;

			
			if (a < b)
			{
				for (int i = a; i <= b; i++)
				{
					result *= i;
				}
			}
			else
			{
				for (int i = b; i <= a; i++)
				{
					result *= i;
				}
			}
			

			return result;
		}

		// 10
		public static double aveArray(int[] numbers)
		{
			int sum = 0;

			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}
			double ave = (double)sum / numbers.Length;

			return ave;
		}
	}
}
