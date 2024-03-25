using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryProductRepository : IProductRepository
    {
        List<Product> _products;

        public InMemoryProductRepository()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            _products.Remove(product);

        }

        public List<Product> GetAll()
        {
            return this._products;
        }

        public Product GetById(int id)
        {
            // LINQ => SQL'in C# hali
            return _products.FirstOrDefault(x => x.Id == id);

        }

        public void Update(Product updatedProduct)
        {
            // InMemory olduğundan atla.
        }
    }
}