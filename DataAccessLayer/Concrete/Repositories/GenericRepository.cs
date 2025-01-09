 using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object; //object Tlere karşılık gelen sınıfı tutuyor.
        public GenericRepository()
        {
            _object = c.Set<T>(); //objectin değeri contexte bağlı olarak gönderilen t değeri object dışarıdan gönderdğim entityim neyse o olacak
        }
        public void Delete(T p)
        {
            var deletedEntity=c.Entry(p);
            deletedEntity.State=EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //Sadece bir tane geriye değer döndürmek için kullanılan entityframework Linqdur.
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p); //ekleyeceğim değeri addedentity içerisine atadım
            addedEntity.State = EntityState.Added;
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State=EntityState.Modified;
            c.SaveChanges();
        }
    }
}
