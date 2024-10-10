using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\USER\Downloads\info.txt";

			using (StreamWriter sw = new StreamWriter(path))
			{
				sw.WriteLine("Razan Alsamri ");
				sw.WriteLine("My age is 21 ");
				sw.WriteLine("My major is Software Engineering");
			}
			string lines = "";
		
				using (StreamReader reader = new StreamReader(path))
				{
				
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						Console.WriteLine(line);
					lines += line;
				}
                Console.WriteLine(lines);
				int count = 0;
                for (int i = 0; i < lines.Length; i++)
                {
					if (lines[i].ToString() != " ")
					{
						count++;
					}
                }
                Console.WriteLine($"The number of characters in the file is: {count}");
            }

			string[] chars = lines.Split(' ');
			int counter = 0;
			foreach (string s in chars)
			{
				counter++;
			}

			Console.WriteLine("The number of words in the file equals :" + counter);


		}
	}
}
