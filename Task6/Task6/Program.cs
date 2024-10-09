using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Car myCar = new Car(1, "Toyota", 2020, "SUV", "RAV4", "Blue", 30000, 12345);

		
			Console.WriteLine(myCar.fullInformation(myCar));


		}
		public class Vehicle
		{
			public int id {  get; set; }
			public string make { get; set; }

			public Vehicle(int id , string make) 
			{
				this.id = id;
				this.make = make;
			
			}
		}
		public class Car : Vehicle 
		{
			public int year { get; set; }
			public string type { get; set; }
			public string model { get; set; }
			public string color { get; set; }
			public double price { get; set; }
			public int palletNo { get; set; }

			public bool engine {  get; set; }

			public Car(int id , string make ,int year, string type, string model, string color, double price, int palletNo) : base (id ,make)
			{
				this.year = year;
				this.type = type;
				this.model = model;
				this.color = color;
				this.price = price;
				this.palletNo = palletNo;
			}

			public bool startOrStopEngine()
			{
				engine = !engine;
				if (engine)
				{
                    Console.WriteLine("start engine");
					return true;
				}
				else
				{
					Console.WriteLine("stop engine");
					return false;
				}
			}

			public string fullInformation(Car car)
			{
				return $"Car Details: Make: {car.make}, Year: {car.year}, Type: {car.type}, " +
		   $"Model: {car.model}, Color: {car.color}, Price: ${car.price}, " +
		   $"Pallet No: {car.palletNo}";
			}

		}



	}
}
