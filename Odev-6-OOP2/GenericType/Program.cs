using System;
using System.Collections.Generic;


//GenericType(Generic Tür), tür güvenliği sağlayan ve aynı kod bloğunu farklı türlerle çalışacak şekilde genelleştiren bir özelliktir. 
//Generic tipler, belirli bir türü tanımlamak yerine, kodu birden fazla türle kullanılabilir hale getirir. 
public abstract class BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Student: BaseEntity
{
    public string Department { get; set; }
}

public class Product: BaseEntity
{
    public decimal Price { get; set; }
}

//Generic class
public class Repository<T>
{
    private List<T> _items = new List<T>();

    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        //Main metodu içinde önce Repository<Student> ve sonra Repository<Product> örnekleri oluşturularak,
        //bu generic sınıfın farklı model class'ları ile kullanımı gösterilmiştir.
        //Bu sayede, farklı türdeki model class'ları için aynı generic yapıyı kullanarak kod tekrarı önlenir ve kodun genel yapısı sağlanır.
       
        Repository<Student> studentRepository = new Repository<Student>();
        studentRepository.AddItem(new Student { Id = 1, Name = "Alice", Department = "Computer Science" });
        studentRepository.AddItem(new Student { Id = 2, Name = "Bob", Department = "Mathematics" });
        studentRepository.DisplayItems();

        Repository<Product> productRepository = new Repository<Product>();
        productRepository.AddItem(new Product { Id = 101, Name = "Laptop", Price = 15000 });
        productRepository.AddItem(new Product { Id = 102, Name = "Phone", Price = 8000 });
        productRepository.DisplayItems();
    }
}