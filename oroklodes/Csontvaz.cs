using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes
{
	internal class Csontvaz:Karakter
	{
		public Csontvaz(string Nev, int Elet, int Sebzes) : base(Nev, Elet, Sebzes)
		{

		}
		public override void Tamad()
		{
			Console.WriteLine($"{Nev} íjjal lő, {Sebzes}HP-t sebez.");
		}
	}
}
