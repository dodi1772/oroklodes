using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes
{
	internal class Karakter
	{
		public string Nev {  get; set; }
		public int Elet { get; set; }
		public int Sebzes { get; set; }

		public Karakter(string Nev, int Elet, int sebzes)
		{
			this.Nev = Nev;
			this.Elet = Elet;
			Sebzes = sebzes;
		}
		public virtual void Tamad()
		{
            Console.WriteLine($"{Nev} felvéve, {Sebzes}HP-t sebez.");
        }
		public static void Harcol(Karakter k1, Karakter k2)
		{
			int k1Pont = k1.Elet + k1.Sebzes;
			int k2Pont = k2.Elet + k2.Sebzes;
            Console.WriteLine($"Harcol: {k1.Nev} vs {k2.Nev}");
            if (k1Pont > k2Pont)
			{
				Console.WriteLine($"{k1.Nev} győzött!");
			}
			else if (k1Pont < k2Pont)
			{
				Console.WriteLine($"{k2.Nev} győzött!");
			}
			else
			{
				Console.WriteLine("Döntetlen!");
			}
		}
	}
}
