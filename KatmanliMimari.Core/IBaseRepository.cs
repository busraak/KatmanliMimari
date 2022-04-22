using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Core
{
    public interface IBaseRepository<T> where T: class
    {
        bool Update(T ent);
        bool Create(T ent);
        bool Delete(T ent);
        T Find(int id);
        T Find(string id);
        T Find(int key1, int key2);
  
        DbSet<T> Set(); 
        IQueryable<T> Qry();
    }
}
