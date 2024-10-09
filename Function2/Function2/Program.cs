using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Function2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(getDays(new DateTime(2019,7,14), new DateTime(2019,7,20)));
			numInStr(new[] { "1a", "a", "2b", "b" });
			reverseOdd("One two three four");
			isPandigital(90864523148909);
		}

		// 1
		public static string getDays(DateTime date1, DateTime date2)
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

			return $"Number of days : {days} days ";
		}

		// 2
		static string[] numInStr(string[] arr)
		{
			List<string> result = new List<string>();

			foreach (string str in arr)
			{
				foreach (char c in str)
				{
					if (char.IsDigit(c))
					{
                        
						result.Add(str);
						Console.WriteLine(str);
						break;
					}
				}
			}

			return result.ToArray();
		}

		// 3
		public static void reverseOdd(string str)
		{
			string reversed = "";
			string[] strings = str.Split(' ');
			for (int i = 0; i < strings.Length; i++)
			{
				if (strings[i].Length%2 != 0) 
				{
					char[] charArray = strings[i].ToCharArray();
					Array.Reverse(charArray);
					reversed += new string(charArray);
				}

				else 
				{
					reversed += strings[i];
				}

				if (i < strings.Length - 1) 
				{
					reversed += " ";
				}
			}
            Console.WriteLine(reversed);
		}

		// 4 
		public static bool isPandigital(long number)
		{
			int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			string numString = number.ToString();
			foreach (var num in nums)
			{
				if (!numString.Contains(num.ToString()))
				{
					Console.WriteLine($"It is not a pandigital!");
					return false;
				}
			}

			Console.WriteLine("It is pandigital!");
			return true;
		}

	}
}
