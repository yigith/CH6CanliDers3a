namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Karesi(3.3m));

            // ibretlik: neden hata veriyor düşünün
            // Console.WriteLine(Karesi(3));
        }

        static double Karesi(double sayi)
        {
            return sayi * sayi;
        }

        static decimal Karesi(decimal sayi)
        {
            return sayi * sayi;
        }
    }
}
