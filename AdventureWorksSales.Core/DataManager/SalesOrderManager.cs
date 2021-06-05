using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksSales.Core.Repository;


namespace AdventureWorksSales.Core.DataManager
{
    public class SalesOrderManager : DataRepositoryManager<SalesOrder>, ISalesOrderRepository
    {
        private readonly AdventureWorksSalesDbContext _context;

        public SalesOrderManager(AdventureWorksSalesDbContext context) : base(context)
        {
            _context = context;
        }

        public int FrontBrakesTotal()
        {
          var query =  from wallets in _context.SalesOrders
            join roundedsvings in _context.Products on wallets.ProductID equals roundedsvings.ProductID
            where roundedsvings.Name == "front brakes"
                       select new { value = wallets.LineTotal };

            return query.Count();
        }

        public int GetTotalCount()
        {
           return _context.SalesOrders.Count();
        }

      

        public decimal HighestLineTotal()
        {
            return _context.SalesOrders.OrderByDescending(x => x.LineTotal).First().LineTotal;
        }
    }
}
