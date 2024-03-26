using Entities.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): new'lenebilir olmalı (IEntity newlenemez)
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //Filtre vermeye bilir. filtre örn: _productDal.GetAll(p =>p.CategoryId==2)
        T Get(Expression<Func<T, bool>> filter); //filtre zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
