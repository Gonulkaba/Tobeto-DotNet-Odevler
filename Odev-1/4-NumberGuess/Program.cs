//Kullanıcıdan 1 ile 10 arasında rastgele bir sayıyı tahmin etmesini isteyen ve doğru tahmin edene kadar devam eden bir program yazınız.

Random random = new Random();
int randomNumber = random.Next(1,10);

Console.WriteLine("1 ile 10 arasında bir sayı tahmini giriniz: ");
int guess = Convert.ToInt32(Console.ReadLine());

while (guess != randomNumber)
{
    Console.WriteLine("Yanlış tahmin:( Tekrar deneyin..");
    guess = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("TEBRİKLER!! Doğru tahmin :) "+ randomNumber);