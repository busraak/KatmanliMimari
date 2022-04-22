using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.DTO
{
    public class ProductsSelect
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? CategoryName { get; set; }
        public decimal UnitPrice { get; set; }
    }

}
