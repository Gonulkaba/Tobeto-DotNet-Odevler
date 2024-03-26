using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetAllByCategoryId(2))
{
    Console.WriteLine(product.ProductName);    
}