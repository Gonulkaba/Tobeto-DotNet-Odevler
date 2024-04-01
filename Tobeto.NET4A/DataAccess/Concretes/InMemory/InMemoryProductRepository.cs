using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public Task AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            _products.Remove(product);

        }

        public Task DeleteAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product? Get(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>>? orderBy = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return this._products;
        }

        public Task<Product?> GetAsync(Expression<Func<Product, bool>> predicate, Expression<Func<Product, object>>? orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            // LINQ => SQL'in C# hali
            return _products.FirstOrDefault(x => x.Id == id);

        }

        public List<Product> GetList(Expression<Func<Product, bool>>? predicate, Expression<Func<Product, object>>? orderBy = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetListAsync(Expression<Func<Product, bool>>? predicate = null, Expression<Func<Product, object>>? orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product updatedProduct)
        {
            // InMemory olduğundan atla.
        }

        public Task UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}