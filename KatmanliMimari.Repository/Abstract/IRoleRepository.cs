using KatmanliMimari.Core;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Abstract
{
    public interface IRoleRepository:IBaseRepository<AspNetRole>
    {
        IQueryable<RoleSelect> GetRoles();
    }
}
