using Business.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        List<Product> _products;

        public ProductManager()
        {
            this._products = new List<Product>();
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public List<Product> GetAll()
        {
            return this._products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);

        }

        public void Update(Product updatedProduct)
        {
            Product product = _products.FirstOrDefault(x => x.Id == updatedProduct.Id);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.UnitPrice = updatedProduct.UnitPrice;
            }
        }
    }
}
