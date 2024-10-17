
void SaatiGoster()
{
    Console.Clear();
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Thread.Sleep(1000); // 1 saniye akışı uyut
    SaatiGoster();
}

SaatiGoster();

Console.ReadKey();
