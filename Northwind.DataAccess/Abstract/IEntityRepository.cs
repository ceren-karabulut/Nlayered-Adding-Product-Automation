using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Abstract
{
   public interface IEntityRepository<T> where T:class,IEntity,new() //Generic kısıtlama.
       //Repository Generic:Gelecekte farklı metotların yazılması
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);     //filtre isterse yapar.
        T Get(Expression<Func<T,bool>> filter);     //kullanıcı mutlaka filtre versin.Örneğin kategori id/product id göre 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
