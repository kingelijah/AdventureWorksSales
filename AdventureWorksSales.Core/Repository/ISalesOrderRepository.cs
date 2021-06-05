using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales.Core.Repository
{
    public interface ISalesOrderRepository : IDataRepository<SalesOrder>
    {
        int GetTotalCount();
        decimal HighestLineTotal();
        int FrontBrakesTotal();

    }
}
