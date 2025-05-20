using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes
{
	internal class Zombi:Karakter
	{
		public Zombi(string Nev, int Elet, int Sebzes) :base(Nev,Elet,Sebzes)
		{

		}
		public override void Tamad()
		{
            Console.WriteLine($"{Nev} hörögve támadgat, {Sebzes}HP-t sebez.");
        }
	}
}
