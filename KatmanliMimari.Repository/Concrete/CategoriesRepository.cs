using KatmanliMimari.Core;
using KatmanliMimari.Dal;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity;
using KatmanliMimari.Entity.Users;
using KatmanliMimari.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Concrete
{
    public class CategoriesRepository:BaseRepository<Category>,ICategoriesRepository
    {
        public CategoriesRepository(/*Context db*/ KatmanliMimariDbCore6Context db) : base(db/*, userdb*/)
        {

        }

        public IQueryable<CategoriesSelect> GetCategoriesSelects()
        {
            return Set().Select(x => new CategoriesSelect
            {
                Id = x.Id,
                CategoryName = x.CategoryName
            });
        }
    }
}
