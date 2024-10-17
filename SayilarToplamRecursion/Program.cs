int Topla(int sayi)
{
    //if (sayi < 0)
    //    throw new Exception("negatif sayılar girilemez!");

    if (sayi == 0 || sayi == 1)
        return sayi;

    return sayi + Topla(sayi - 1);
}

Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int toplam = Topla(n);

Console.WriteLine($"1'den {n}'e sayıların toplamı: {toplam}");
Console.ReadKey();