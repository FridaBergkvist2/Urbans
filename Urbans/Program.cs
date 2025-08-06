using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<Produkt> produkter = new List<Produkt>();
		bool kör = true;

		while (kör)
		{
			Console.Write("Ange grönsak (eller skriv 'stopp' för att avsluta):");
			string namn = Console.ReadLine();

			if (namn.ToLower() == "stopp")
			{
				kör = false;
				continue;
			}	

			Console.Write("Ange antal:");
			double antal = Convert.ToDouble(Console.ReadLine());

			produkter.Add(new Produkt(namn,antal));
		}

		Console.WriteLine("\n--- Grönsakslista ---");
		foreach (Produkt p in produkter)
		{
			p.VisaInfo();
		}
	}
}




