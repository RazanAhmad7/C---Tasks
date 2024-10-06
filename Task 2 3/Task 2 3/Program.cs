using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			QuestionThree(1, 6, 0);
			// Question one
			void QuestionOne()
			{
				int num1 = int.Parse(Console.ReadLine());
				int num2 = int.Parse(Console.ReadLine());
				if (num1 < num2)
				{
					Console.WriteLine(num1);
				}
				else { 
					Console.WriteLine(num2);
				}
			}

			void QuestionTwo()
			{
				int num= int.Parse(Console.ReadLine());
				Console.WriteLine(num < 0 ? "The sign is - " : "The sign is + ");
			}

			void QuestionThree(int num1,int num2, int num3)
			{
				int temp;

				// Sorting numbers in ascending order using conditional statements
				if (num1 > num2)
				{
					temp = num1;
					num1 = num2;
					num2 = temp;
				}

				if (num1 > num3)
				{
					temp = num1;
					num1 = num3;
					num3 = temp;
				}

				if (num2 > num3)
				{
					temp = num2;
					num2 = num3;
					num3 = temp;
				}

				// Displaying numbers in descending order
				Console.WriteLine($"{num3}, {num2}, {num1}");
			}

		}
	}
}
