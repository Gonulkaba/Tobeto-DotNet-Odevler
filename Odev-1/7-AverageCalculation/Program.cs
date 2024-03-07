//Kullanıcıdan öğrenci sayısını isteyen her öğrenci için öğrenci adı, öğrenci soyadı, 1.sınav notu, 2.sınav notu, 3.sınav notu isteyen ve daha sonra not ortalamasını hesaplayıp ekrana yazdıran algoritma yapınız.

Console.Write("Öğrenci sayısını giriniz: ");
int studentCount = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= studentCount; i++)
{
    double averageGrade = 0;

    Console.WriteLine("------------" + i + ". öğrencinin Bilgileri ------------");
    Console.Write("Öğrencinin adını giriniz: ");
    string studentName = Console.ReadLine();
    Console.Write("Öğrencinin soyadını giriniz: ");
    string studetSurname = Console.ReadLine();
    for (int j = 1; j <= 3; j++)
    {
        Console.Write("Öğrencinin " + j + ". sınav notunu giriniz: ");
        averageGrade += Convert.ToDouble(Console.ReadLine());
    }
    averageGrade /= 3;
    Console.WriteLine(studentName + studetSurname+ " adlı öğrencinin not ortalaması: " + averageGrade);
}

//Kullanıcı veri girişlerinde, hatalı veri türü girişleri kontrolu yapılmadı!