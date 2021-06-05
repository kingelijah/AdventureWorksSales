using AdventureWorksSales.Core;
using AdventureWorksSales.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorksSales.Web.Controllers
{
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryController(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
        public ActionResult Index()
        {
            var Model = _productCategoryRepository.GetAll();
            return View(Model);
        }
        public ActionResult Edit(int Id)
        {

            var std = _productCategoryRepository.GetValue(Id);
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(ProductCategory std)
        {

            var student = _productCategoryRepository.GetValue(std.ProductCategoryID);
            _productCategoryRepository.Delete(student);
            _productCategoryRepository.Add(std);

            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(ProductCategory productCategory)
        {
            _productCategoryRepository.Add(productCategory);
            return RedirectToAction("Index");

        }
    }
}