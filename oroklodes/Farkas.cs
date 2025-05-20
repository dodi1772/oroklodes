using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes
{
	internal class Farkas:Karakter
	{
		public bool Szeliditett {  get; set; }
		public Farkas(bool szeliditett, string Nev, int Elet, int Sebzes)
			:base(Nev, Elet, Sebzes)
		{
			Szeliditett = szeliditett;
		}
		public override void Tamad()
		{
            if (Szeliditett)
            {
                Console.WriteLine($"{Nev} veled támad, {Sebzes}HP-t sebezne.");
            }
			else
			{
                Console.WriteLine($"{Nev} megharapott, {Sebzes}HP-t sebez.");
            }
        }
	}
}
