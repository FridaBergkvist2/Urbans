using System;

public class Produkt
{
	private string namn;
	private double antal;	

	public string Namn
	{ 
		get {return namn; } 
		set 
		{
			if (!string.IsNullOrWhiteSpace(value))
			    namn = value;
		}
	}

	public double Antal
	{
		get {return antal;}
		set
		{
			if (value>=0)
			antal = value;
		}
	}
	
	public Produkt (string namn, double antal)
	{
		Namn = namn;
		Antal = antal;
	}
	
	public void VisaInfo()
	{
		Console.WriteLine($"Namn: {Namn}, Antal: {Antal}");
	}
}

