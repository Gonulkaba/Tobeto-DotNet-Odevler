using System;

//Encapsulation (Kapsülleme) nedir?
//Bir sınıfa ait değişkenlerin veya niteliklerin ancak o sınıfa ait metotlar tarafından değiştirilebilmesi ve okunabilmesi ilkesidir. 
public class Person
{
    //sınıf içinde _name ve _age adında private (özel) veri alanları kullanılmıştır.
    //Bu veri alanlarına sadece Name ve Age adında public (genel) property'ler aracılığıyla erişim sağlanabilir.
    private string _name;
    private int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Geçersiz yaş!");
            }
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_name}, Age: {_age}");
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        person.Name = "Gönül";
        person.Age = 24;

        person.DisplayInfo();
    }
}