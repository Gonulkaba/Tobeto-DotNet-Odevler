﻿using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId= 1,CategoryId= 1,ProductName= "Bardak", UnitsInStock=50,UnitPrice= 20 } ,
                new Product{ProductId= 2,CategoryId= 1,ProductName= "Kamera", UnitsInStock=30,UnitPrice= 5000 },
                new Product{ProductId= 3,CategoryId= 2,ProductName= "Telefon", UnitsInStock=20,UnitPrice= 2000 },
                new Product{ProductId= 4,CategoryId= 2,ProductName= "Klavye", UnitsInStock=60,UnitPrice= 600 },
                new Product{ProductId= 5,CategoryId= 2,ProductName= "Fare", UnitsInStock=40,UnitPrice= 200 }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

    }
}
