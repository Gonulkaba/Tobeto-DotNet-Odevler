using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Product.Requests;
using Business.Dtos.Product.Responses;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.DataAccess;
using DataAccess.Abstracts;
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
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductManager(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task Add(AddProductRequest dto)
        {
            // ürün ismini kontrol et
            // fiyatını kontrol et

            if (dto.UnitPrice < 0)
                throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");

            // Aynı isimde ikinci ürün eklenemesin.
            Product? productWithSameName =await _productRepository.GetAsync(p => p.Name == dto.Name);
            if (productWithSameName is not null)
                throw new System.Exception("Aynı isimde 2. ürün eklenemez");
            /*
            //Mapping(Manual)
            //AutoMapping
            Product product = new();
            product.Name = dto.Name;
            product.UnitPrice = dto.UnitPrice;
            product.CategoryId=dto.CategoryId;
            product.CreatedDate=DateTime.Now;
            */

            Product product=_mapper.Map<Product>(dto);
            await _productRepository.AddAsync(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public async Task<List<ListProductResponse>> GetAll()
        {
            
            List<Product> products = await _productRepository.GetListAsync();
            /*
            //Manual Mapping
            List<ProductForListingDto> response = products.Select(p => new ProductForListingDto()
            {
                Id=p.Id,
                Name=p.Name,
                UnitPrice=p.UnitPrice,
            }).ToList();
            */

            List<ListProductResponse> response = _mapper.Map <List< ListProductResponse >> (products); 
            return response;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
