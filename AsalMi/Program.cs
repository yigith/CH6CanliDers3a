// 1'e ve kendinden başka sayıya bölünmeyen
// en küçük asal sayı 2'dir

bool AsalMi(int sayi)
{
    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
            return false;
    }

    return true;
}

Console.Write("Sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AsalMi(sayi) ? "Asal" : "Asal Değil");

Console.ReadKey();