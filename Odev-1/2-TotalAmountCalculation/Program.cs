//Kullanıcıdan kaç ürün almak istediğini soran, her ürünün fiyatını alarak toplam alışveriş tutarını hesaplayan bir algoritma yazınız. 

Console.Write("Kaç ürün almak istersiniz?: ");
int itemCount = Convert.ToInt32(Console.ReadLine());

double totalPrice = 0;

for (int i = 1; i <= itemCount; i++)
{
    Console.Write(i + ". ürünün fiyatını giriniz: ");
    totalPrice += Convert.ToDouble(Console.ReadLine());
}
Console.Write(itemCount + " ürünün toplam tutarı: " + totalPrice);
Console.ReadKey();
