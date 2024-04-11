class Mial
{
    static void Main(string[] args)
    {
        bool[] liczby = new bool[100];
        WypelnianieLiczby(liczby);
    }

    static void WypelnianieLiczby(bool[] tablica)
    {
        for(int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = true;
        }
    }
}