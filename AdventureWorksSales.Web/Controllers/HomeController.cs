using AdventureWorksSales.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISalesOrderRepository _salesOrderRepository;

        public HomeController(ISalesOrderRepository salesOrderRepository)
        {
            _salesOrderRepository = salesOrderRepository;
        }

        public ActionResult Index()
        {
            ViewBag.HighestLine = Math.Round(_salesOrderRepository.HighestLineTotal()); 
            ViewBag.FrontBrakes = _salesOrderRepository.FrontBrakesTotal();
            ViewBag.TotalCount = _salesOrderRepository.GetTotalCount();
            return View();
        }

        public ActionResult Product()
        {
           
            return View();
        }
        public ActionResult ProductCategory()
        {

            return View();
        }

        public ActionResult SalesOrder()
        {
            
            return View();
        }
    }
}