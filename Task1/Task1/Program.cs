using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Question 1
			Console.WriteLine(Console.ReadLine());

			// Question 2
			string myName = "Razan";
			char firstLetter = 'R';
			int myAge = 21;
			double myAvg = 90.4;
			bool isGraduated = false;
			const double p = 3.14;



			// Question 3 
			string[] cars = { "BMW" , "Ford" ,"Mercedes" };
			foreach (var car in cars)
			{
				Console.WriteLine(car);
			}
			Console.WriteLine("Length of the array: " + cars.Length);

            // Question 4 
            Console.Write("Input your first name :");
			string firstName = Console.ReadLine();
			Console.Write("Input your last name :");
			string lastName = Console.ReadLine();
			Console.Write("Input your year of birth :");
			string birthYear = Console.ReadLine();
            Console.WriteLine(firstName + " "  + lastName + " " + birthYear);


			// Quesion 5 
			int[] elements = new int[10];
			for (int i = 0; i < 10; i++)
			{
                Console.Write("element - " + i + " :");
				elements[i] = Convert.ToInt32(Console.ReadLine());

			}
            Console.Write("Elements in array are: ");
			Console.WriteLine();

			for (int i = 0;i < 10; i++)
			{
                Console.Write(elements[i] + " ");
			}


			// Question 6 
			int[] elements2 = new int[5];
			for (int i = 0; i < 5; i++)
			{
				Console.Write("index - " + i + " :");
				elements[i] = Convert.ToInt32(Console.ReadLine());

			}
            Console.WriteLine();
			int sum = 0;

			for (int i = 0; i < elements2.Length; i++)
			{
				sum += elements[i];
			}
			Console.Write("Sum of all elements stored in the array is : " + sum);
			Console.WriteLine();
		}
	}
}
