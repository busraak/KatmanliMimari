using KatmanliMimari.DTO;
using KatmanliMimari.Entity.Users;

namespace KatmanliMimari.Ui.Models
{
    public class UserRoleModel
    {
        
        public AspNetUser AspNetUsers { get; set; }
        //public AspNetRole AspNetRoles { get; set; }
        public IQueryable<RoleSelect> RoleSelect { get; set; }
        //public IQueryable<UserRoleSelect> UserRoleSelect { get; set; }

    }
}
