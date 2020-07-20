using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generic_CRUD_ASP.NET_CORE_3._1.DAL;
using Generic_CRUD_ASP.NET_CORE_3._1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Generic_CRUD_ASP.NET_CORE_3._1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductsDAO _productsDAO;
        public ProductsController(ProductsDAO productsDAO)
        {
            _productsDAO = productsDAO;
        }

        // GET: ProductsController
        public ActionResult Index()
        {
            var model = _productsDAO.List();
            return View(model);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _productsDAO.FindProduct(id);

            return View(model);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {

            try
            {
                _productsDAO.Create(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(Guid id)
        {
            var model = _productsDAO.FindProduct(id);
            return View(model);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                _productsDAO.Update(product);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _productsDAO.FindProduct(id);
            return View(model);
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                _productsDAO.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
