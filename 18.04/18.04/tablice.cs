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

	public void WyswietlTab(int[] tablica)
	{
		for (int i = 0;i < tablica.Length;i++)
		{
			Console.WriteLine(tablica[i]);
			Console.WriteLine();
		}
	}

	public void SortowanieBb(int[] tab)
	{
		for (int i = 0; i < tab.Length; i++)
		{
			for (int j = 1; j < tab.Length - 1; j++)
			{
				if (tab[j - 1] > tab[j])
				{
					int temp = tab[j - 1];
					tab[j - 1] = tab[j];
					tab[j] = temp;
				}
			}
		}
	}
}
