using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksSales.Core.Repository;
using System.Threading.Tasks;

namespace AdventureWorksSales.Core.DataManager
{
    public class ProductManager : DataRepositoryManager<Product>, IProductRepository
    {
        private readonly AdventureWorksSalesDbContext _context;

        public ProductManager(AdventureWorksSalesDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
