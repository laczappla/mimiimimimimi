﻿class Program
{
    static void Main(string[] args)
    {
        //wywołaj obiekt tablica
        Tablice tablice = new Tablice();

        tablice.Powitanie();

        int[] tab = tablice.StworzTablice();

        tablice.WyswietlTab(tab);

        tablice.SortowanieBb(tab);
        tablice.WyswietlTab(tab);
    }
}