
void TersineCevir(ref string metin)
{
    if (string.IsNullOrEmpty(metin) || metin.Length == 1)
        return; // *** dipnot oku

    string sonuc = "";

    for (int i = metin.Length - 1; i >= 0; i--)
    {
        char c = metin[i];
        sonuc += c;
    }

    metin = sonuc;
}

string x = "melis";
TersineCevir(ref x);
Console.WriteLine(x);

void Buyut(ref string ad)
{
    ad = ad.ToUpper();
}

string isim = "hamit";
Buyut(ref isim);
Console.WriteLine(isim);

Console.ReadKey();

// *** dipnot: ref ile alınan değişkene her zaman yeni bir değer koymak/atamak zorunda değilsiniz (örnek için yukarıdaki if koşuluna bakınız)