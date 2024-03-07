//Do-while ve While döngüsü nedir? Bununla ilgili örnek yapınız.

//Do-While: Döngü koşulu doğru olduğu sürece içerisindeki kod blogunu tekrar çalıştırır.
//Koşul döngü bloğu çalıştırıldıktan sonra kontrol edildiğinden döngü en az bir kez çalışmış olur.

//Do-While örnek: Kullanıcıdna bir sayı girmesni isteyelim ve girilen sayı çift olduğu sürece bu işlemi tekrar edelim..
int number;
do
{
    Console.WriteLine("Bir sayı giriniz: ");
    number=Convert.ToInt32(Console.ReadLine()); 

} while (number % 2 ==0);


//While: Döngü koşulu doğru olduğu sürece içerisindeki kod blogunu tekrar çalıştırır.
//Döngüye girmeden önce koşul kontrolü yapıldıgından döngü hiç çalışmayadabilir.

//Do-While örnek: 1den 10a kadar olan sayıları yazdıralım.
int number2=1;
while (number2 <=10)
{
    Console.WriteLine("Sayı: " + number2);
    number2++;
} 