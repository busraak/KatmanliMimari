using KatmanliMimari.DTO;
using KatmanliMimari.Entity;
using KatmanliMimari.Entity.Users;

namespace KatmanliMimari.Ui.Models
{
    public class ProductModel
    {
        public IQueryable<CategoriesSelect> CategoriesSelects { get; set; }
        public string? BtnVal { get; set; }
        public string? BtnClass { get; set; }
        public string? BtnHead { get; set; }
        public Product Products { get; set; }
    }
}
