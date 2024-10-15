// 2 üzeri 3 hesaplayalım
Console.WriteLine("2 üzeri 3: " + Math.Pow(2, 3));

// 3 üzeri 2 hesaplayalım
Console.WriteLine("3 üzeri 2: " + Math.Pow(3, 2));

// SORU: Ben eğer istersem aynı metodu kullanarak
// önce kuvveti sonra sayıyı girebilir miyim?
Console.WriteLine("2 üzeri 3'ü bir daha hesaplayalım:");
double sonuc = Math.Pow(y: 3, x: 2);
Console.WriteLine(sonuc);

Console.ReadKey();