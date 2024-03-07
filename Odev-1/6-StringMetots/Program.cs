//String metotlarını araştırınız. Her bir metot için örnek yapınız.

string text = "Merhaba benim adım Gönül";

//Lenght: Bir dizenin karakter sayısını döndürür.
Console.WriteLine(text+ " dizesinin karakter sayısı: " + text.Length);

//ToUpper(): Bir dizenin tüm karakterlerini büyük harfe dönüştürür.
Console.WriteLine(text + " dizesinin Büyük  harfe dönüştürülmüş hali:\n " + text.ToUpper());

//ToLower(): Bir dizenin tüm karakterlerini küçük harfe dönüştürür.
Console.WriteLine(text + " dizesinin Küçük  harfe dönüştürülmüş hali:\n " + text.ToLower());

//Substring(startIndex, lenght): Bir dizeden belirli bir alt dizeyi alır. Başlangıç dizini ve alt dizenin uzunluğu belirtilir.
Console.WriteLine(text + " dizesi içerisindeki son kelime:\n " + text.Substring(19,5));

//Contains(substring): Bir dizenin belirli bir alt dizeyi içerip içermediğini kontrol eder. True- false döner.
if(text.Contains("Gönül"))
    Console.WriteLine(text + " dizesi 'Gönül' alt dizesini içermektedir.");
else
    Console.WriteLine(text + " dizesi 'Gönül' alt dizesini içermemektedir.");





