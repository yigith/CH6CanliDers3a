string ad = "berkan";

foreach (char c in ad)
{
    Console.WriteLine(c);
}

Console.WriteLine("------------------");

for (int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(ad[i]);
}

Console.ReadKey();