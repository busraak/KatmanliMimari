using KatmanliMimari.Core;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity;
using KatmanliMimari.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Abstract
{
    public interface ICategoriesRepository : IBaseRepository<Category>
    {
        IQueryable<CategoriesSelect> GetCategoriesSelects();
    }
}
