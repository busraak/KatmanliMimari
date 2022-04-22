using KatmanliMimari.DTO;
using KatmanliMimari.Entity.Users;

namespace KatmanliMimari.Ui.Models
{
    public class UserModel
    {
        public AspNetUser? AspNetUsers { get; set; }
        public IQueryable<RoleSelect> RoleSelect { get; set; }
    }
}
