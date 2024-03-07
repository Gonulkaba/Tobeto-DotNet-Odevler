//Bir sayının mükemmel sayı olup olmadığını kontrol eden algoritma yazın.

//Mükemmel sayı: kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayıdır.

Console.WriteLine("Bir sayı giriniz: ");
int number= Convert.ToInt32(Console.ReadLine());

int sumOfDivisors = 0;
for (int i = 1; i < number; i++)
{
    if (number % i == 0) 
    {
        sumOfDivisors += i;
    }
}
if(sumOfDivisors == number)
{
    Console.WriteLine(number + " sayısı mükemmel bir sayıdır.");
}
else
{
    Console.WriteLine(number + " sayısı mükemmel bir sayı değildir.");
}