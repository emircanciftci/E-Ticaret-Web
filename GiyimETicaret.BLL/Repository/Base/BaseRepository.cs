using GiyimETicaret.DAL.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GiyimETicaret.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private GiyimETicaretEntities db;
        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new GiyimETicaretEntities();
            table = db.Set<T>();
        }
        public int Save()
        {
            return db.SaveChanges();
        }
        public virtual void Insert(T entity)
        {
            table.Add(entity);
            Save();
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(long ID)
        {
            return table.Find(ID);
        }
    }
}
