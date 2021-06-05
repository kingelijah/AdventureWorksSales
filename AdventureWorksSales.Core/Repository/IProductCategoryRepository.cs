using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales.Core.Repository
{
    public interface IProductCategoryRepository : IDataRepository<ProductCategory>
    {
        ProductCategory GetValue(int id);

    }
}
