using System;
using System.Collections.Generic;

//Polimorfizm, aynı ismi taşıyan ancak farklı parametre listelerine veya
//farklı sınıf hiyerarşilerine sahip olan metodların veya sınıfların kullanılabilirliğini ifade eder.
class Program
{
    static void Main(string[] args)
    {
        EmployeeManager employeeManager = new EmployeeManager();

        //Polimorfizm
        employeeManager.HandleEmployee(new RegularEmployee());
        employeeManager.HandleEmployee(new Manager());

        Console.ReadLine();
    }
}

abstract class Employee
{
    public abstract void CalculateSalary();
}

class RegularEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Normal çalışanın maaşı hesaplandı.");
    }
}

class Manager : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Yönetici maaşı hesaplandı.");
    }
}

class EmployeeManager
{
    //Bu metot, polimorfizmi kullanarak farklı türdeki çalışanları aynı şekilde işlem yapabilmek için kullanır.
    public void HandleEmployee(Employee employee)
    {
        employee.CalculateSalary();
    }
}
