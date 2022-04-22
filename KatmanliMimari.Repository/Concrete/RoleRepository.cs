using KatmanliMimari.Core;
using KatmanliMimari.Dal;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity.Users;
using KatmanliMimari.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Concrete
{
    public class RoleRepository:BaseRepository<AspNetRole>,IRoleRepository
    {
        public RoleRepository(KatmanliMimariDbCore6Context db):base(db)
        {

        }

        public IQueryable<RoleSelect> GetRoles()
        {
            return Set().Select(x => new RoleSelect
            {
                Id = x.Id,
                Name=x.Name
            });
        }
    }
}
