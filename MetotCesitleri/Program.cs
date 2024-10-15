// Parametre Alan Değer Döndüren
string Tersi(string metin)
{
    string sonuc = "";

    foreach (char c in metin)
    {
        sonuc = c + sonuc;
    }

    return sonuc;
}

string tersi = Tersi("gözde");
Console.WriteLine("Gözde'nin Tersi: " + tersi);

// Parametre Alan Değer Döndürmeyen
void TekrarliYazdir(string metin, int kere)
{
    for (int i = 0; i < kere; i++)
        Console.WriteLine(metin);
}

TekrarliYazdir("Ankara'nın Bağları", 7);

// Parametre Almayan Değer Döndüren
int ZarAt()
{
    return new Random().Next(1, 7);
}

int zar = ZarAt();
Console.WriteLine("Gelen Zar: " + zar);

// Parametre Almayan Değer Döndürmeyen
void SaatiYazdir()
{
    Console.WriteLine(DateTime.Now.ToLongTimeString());
}

SaatiYazdir();

Console.ReadKey();