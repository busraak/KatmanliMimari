using KatmanliMimari.Dal;
using KatmanliMimari.Entity.Users;
using KatmanliMimari.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Uow
{
    public class UnitofWork : IUnitofWork
    {
        private readonly KatmanliMimariDbCore6Context _db; //private buradan baska bir yerde kullanılamaz anlamı.
        //private readonly KatmanliMimariDbCore6Context _userdb;

        public UnitofWork(KatmanliMimariDbCore6Context db/*,KatmanliMimariDbCore6Context userdb*/
            ,ICategoriesRepository catRepos
            ,IProductsRepository proRepos
            ,IRoleRepository roleRepos
            ,IUserRepository userRepos)
        {
            _db = db;
           // _userdb = userdb;
            _catRepos = catRepos;
            _proRepos = proRepos;
            _roleRepos = roleRepos;
            _userRepos = userRepos;
           
        }
        public ICategoriesRepository _catRepos {get; private set;}

        public IProductsRepository _proRepos { get; private set; }

        public IRoleRepository _roleRepos { get; private set; }

        public IUserRepository _userRepos { get; private set; }

        

        public void Commit()
        {
            _db.SaveChanges();
        }

     
    }
}
