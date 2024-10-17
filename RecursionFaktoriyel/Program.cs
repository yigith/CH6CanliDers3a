
// 0! = 1
// 1! = 1
// ...
// 5! = 1 * 2 * 3 * 4 * 5

#region Yöntem 2 (Recursion)
// 5! = 4! * 5
int FaktRec(int n)
{
    // base case
    if (n == 0 || n == 1)
        return 1;

    return n * FaktRec(n - 1);
}

Console.WriteLine($"0! = {FaktRec(0)}");
Console.WriteLine($"1! = {FaktRec(1)}");
Console.WriteLine($"5! = {FaktRec(5)}");
#endregion

Console.WriteLine("---------------");

#region Yöntem 1 (for ile)
// bu metot n! 'i hesaplar
int Fakt1(int n)
{
    int sonuc = 1;

    for (int i = 2; i <= n; i++)
        sonuc *= i; // sonuc = sonuc * i

    return sonuc;
}

Console.WriteLine($"0! = {Fakt1(0)}");
Console.WriteLine($"1! = {Fakt1(1)}");
Console.WriteLine($"5! = {Fakt1(5)}"); 
#endregion

Console.ReadKey();