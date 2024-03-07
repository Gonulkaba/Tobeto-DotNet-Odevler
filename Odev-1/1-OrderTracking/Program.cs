//Switch case ile müşteriden alınan sipariş numarasına göre hangi ürünün sipariş edildiğini belirleyen algoritma yazınız.

int control = 1;
while (control==1) 
{ 
    Console.Write("Sipariş numaranızı giriniz:");
    int orderNumber = Convert.ToInt32(Console.ReadLine());

    switch (orderNumber)
    {
        case 1:
            Console.WriteLine("Sipariş edilen ürün: Bilgisayar");
            break;
        case 2:
            Console.WriteLine("Sipariş edilen ürün: Telefon");
            break;
        case 3:
            Console.WriteLine("Sipariş edilen ürün: Televizyon");
            break;
        case 4:
            Console.WriteLine("Sipariş edilen ürün: Laptop");
            break;
        default:
            Console.WriteLine("Geçersiz Sipariş numarası girdiniz..");
            break;
    }

    Console.WriteLine("Tekrar sorgu yapmak için 1'i, çıkış yapmak için 0'ı tuşlayın..");
    control = Convert.ToInt32(Console.ReadLine());
}

//Kullanıcı veri girişlerinde, hatalı veri türü girişleri kontrolu yapılmadı!
