using KatmanliMimari.Core;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity.Users;
using KatmanliMimari.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Concrete
{
    public class UserRepository:BaseRepository<AspNetUser>,IUserRepository
    {
        public UserRepository(KatmanliMimariDbCore6Context db):base(db)
        {

        }

        public List<AspNetUser> GetUsers()
        {
          return  Set().Include(x => x.Roles).ToList();
                
                
        }

        public IQueryable<UserSelect> GetUserSelects()
        {
            return Set().Select(x => new UserSelect
            {
                Id = x.Id,
                UserName = x.UserName
                
               
                
            });
        }
    }
}
