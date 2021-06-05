using AdventureWorksSales.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales.Core.DataManager
{
    public class ProductCategoryManager : DataRepositoryManager<ProductCategory>, IProductCategoryRepository
    {
        private readonly AdventureWorksSalesDbContext _context;

        public ProductCategoryManager(AdventureWorksSalesDbContext context) : base(context)
        {
            _context = context;
        }
        public ProductCategory GetValue(int id)
        {
            return _context.ProductCategories.Where(e => e.ProductCategoryID == id).FirstOrDefault();
        }
    }
}
