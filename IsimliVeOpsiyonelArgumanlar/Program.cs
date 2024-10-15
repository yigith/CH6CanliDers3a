
void Yazdir(string metin, int adet = 1, bool buyult = false, bool ortala = false)
{
    if (buyult)
        metin = metin.ToUpper();


    for (int i = 0; i < adet; i++)
    {
        if (ortala)
        {
            int boslukAdedi = (Console.BufferWidth - metin.Length) / 2;
            Console.Write(new string(' ', boslukAdedi));
        }
        Console.WriteLine(metin);
    }
}

Yazdir("Hamit", 3, true, true);

// Ben Yaşar'ı ortalı yazdırmak istiyorum
// Yazdir metodunu nasıl kullanabilirim?
Yazdir("Yaşar", ortala: true);

Console.ReadKey();