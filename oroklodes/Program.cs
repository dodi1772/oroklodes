namespace oroklodes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Karakter> karakterek = new List<Karakter>();
			karakterek.Add(new Jatekos(20, "Zalan", 5, 100));
			karakterek.Add(new Zombi("DandiDomi", 5, 2));
			karakterek.Add(new Farkas(true, "FüliMali", 5,3));
			karakterek.Add(new Farkas(false, "Papphegyi Öngyújtó", 5, 3));
			karakterek.Add(new Csontvaz("Legyél kreatív", 20, 3));
			foreach (var karakter in karakterek)
            {
                Console.WriteLine($"Név:{karakter.Nev} Élet:{karakter.Elet} ");
				karakter.Tamad();

			};
			Random rng = new Random();

			int rand1 = rng.Next(karakterek.Count);
			int rand2 = rng.Next(karakterek.Count);
			Karakter.Harcol(karakterek[rand1], karakterek[rand2]);
		}
	}
}
