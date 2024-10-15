void SaatiYazdir(bool saniyeGizle = false)
{
    if (saniyeGizle)
    {
        Console.WriteLine(DateTime.Now.ToShortTimeString());
        return; // *** dipnotu oku
    }

    Console.WriteLine(DateTime.Now.ToLongTimeString());
}

SaatiYazdir();
SaatiYazdir(true);

Console.ReadKey();

// *** return keyword'ü void metotlarda derhal çıkış sağlar
// ve sonrasındaki metoda dair hiç bir kod çalışmaz