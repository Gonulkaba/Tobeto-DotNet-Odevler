using System;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}

public class Duty : BaseEntity
{
    public string DutyName { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
}

public class Employee : BaseEntity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Position { get; set; }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee
        {
            Id = 1,
            CreatedDate = DateTime.Now,
            UserName = "Gönül"
        };
        Console.WriteLine(employee.CreatedDate);
    }
}