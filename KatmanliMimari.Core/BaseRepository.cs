using KatmanliMimari.Dal;
using KatmanliMimari.Entity.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Core
{
    public class BaseRepository<T>:IBaseRepository<T> where T : class
    {
        KatmanliMimariDbCore6Context _db;
        //KatmanliMimariDbCore6Context _userdb;

        public BaseRepository(KatmanliMimariDbCore6Context db /*KatmanliMimariDbCore6Context userdb*/)
        {
            _db = db;
            //_userdb = userdb;
        }

        public bool Create(T ent)
        {
            try
            {
                Set().Add(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T ent)
        {
            try
            {
                Set().Remove(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);

        }
        public T Find(string id)
        {
            return Set().Find(id);

        }
        public T Find(int key1, int key2)
        {
            return Set().Find(key1, key2);

        }
      
        public IQueryable<T> Qry()
        {
            return Set().AsQueryable();
        }

        
        public DbSet<T> Set()
        {
            return _db.Set<T>();

        }
      

        public bool Update(T ent)
        {
            try
            {
                Set().Update(ent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
