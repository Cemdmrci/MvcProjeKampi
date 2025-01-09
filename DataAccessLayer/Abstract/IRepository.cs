using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> //T üzerinde çalıştığım entityi çağırır.
    {
        List<T> List();
        void Insert(T p);
        T Get(Expression<Func<T, bool>> filter); //Get metodunun türü T yani entity
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter); //Burdaki Listte komple bir Listi döndürücez,şartlı listeleme yapacak

    }
}
