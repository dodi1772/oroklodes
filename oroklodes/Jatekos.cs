using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes
{
	internal class Jatekos:Karakter
	{
		public int Tapasztalat {  get; set; }
		public Jatekos(int tapasztalat,string Nev,int Elet, int sebzes)
			: base(Nev, Elet, sebzes)
		{
			Tapasztalat = tapasztalat;
		}
	}
}
