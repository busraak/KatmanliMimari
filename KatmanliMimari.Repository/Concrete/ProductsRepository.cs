using KatmanliMimari.Core;
using KatmanliMimari.Dal;
using KatmanliMimari.DTO;
using KatmanliMimari.Entity;
using KatmanliMimari.Entity.Users;
using KatmanliMimari.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Repository.Concrete
{
    public class ProductsRepository:BaseRepository<Product>,IProductsRepository
    {
        public ProductsRepository(/*Context db*/KatmanliMimariDbCore6Context db) : base(db/*, userdb*/)
        {

        }

        public IQueryable<ProductsSelect> GetProductsSelects()
        {
            return Set().Select(x => new ProductsSelect
            {
                Id = x.Id,
                ProductName = x.ProductName,
                CategoryName = x.Category.CategoryName,
                UnitPrice=x.UnitPrice
            });
        }
    }
}
