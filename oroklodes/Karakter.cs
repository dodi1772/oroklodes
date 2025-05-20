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
		public void Harcol(string Nev1, string Nev2)
		{

		}
	}
}
