using KatmanliMimari.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public interface IUnitofWork
    {
        ICategoriesRepository _catRepos {get;}
        IProductsRepository _proRepos {get;}
        IRoleRepository _roleRepos {get;}
        IUserRepository _userRepos { get; }
      
        void Commit();
       
    }
}
