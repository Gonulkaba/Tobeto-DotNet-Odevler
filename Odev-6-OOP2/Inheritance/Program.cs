using System;

//Inheritence(Kalıtım)
//Kalıtım, bir sınıfın (class) özelliklerinin ve davranışlarının başka bir sınıfa miras bırakılmasını sağlayan bir mekanizmadır.
//Kalıtım, kodun yeniden kullanılabilirliğini artırır, kodun daha düzenli ve bakımı daha kolay hale gelmesini sağlar. 
//Kod tekrarını önler.
class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        manager.Name = "Gönül";
        manager.Department = "Mühendislik";

        manager.DisplayInfo();   
        manager.ConductMeeting(); 

        Console.ReadLine();
    }
}
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}");
    }
}

class Manager : Employee
{
    public void ConductMeeting()
    {
        Console.WriteLine("Yönetici tarafından toplantı düzenlendi.");
    }
}


