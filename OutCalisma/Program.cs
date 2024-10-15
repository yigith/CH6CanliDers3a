
void DortIslem(double a, double b, out double toplam, out double fark, out double carpim, out double bolum)
{
    toplam = a + b;
    fark = a - b;
    carpim = a * b;
    bolum = a / b;
}

// peki nasıl kullanırız
// tabaklarımızı hazırlayalım (boş tabaklar)
double top, far, car, bol;

Console.Write("a = ");
double s1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double s2 = Convert.ToDouble(Console.ReadLine());

DortIslem(s1, s2, out top, out far, out car, out bol);
Console.WriteLine("Toplam: " + top);
Console.WriteLine("Fark  : " + far);
Console.WriteLine("Çarpım: " + car);
Console.WriteLine("Bölüm : " + bol);

Console.ReadKey();
