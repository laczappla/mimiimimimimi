using System;

public class Tablice
{
	public void Powitanie()
	{
		Console.WriteLine("witam");
	}

	public int[] StworzTablice() 
	{
		Console.WriteLine("podaj długość tablicy: ");
		int dlugosc = int.Parse(Console.ReadLine());
		int[] tablica = new int[dlugosc];
		for (int i = 0; i < dlugosc; i++)
		{
			Console.WriteLine("podaj kolejny element tablicy: ");
			tablica[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine();
		return tablica;
	}
}
