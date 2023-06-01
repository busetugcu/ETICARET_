using ETİCARET.Context;
using ETİCARET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETİCARET.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = db.products
               .Where(i => i.IsApproved && i.IsHome)
               .Select(i => new ProductModel()
               {
                   Id = i.Id,
                   Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                   Description = i.Description.Length > 80 ? i.Description.Substring(0, 80) + "..." : i.Description,
                   Price = i.Price,
                   Stock = i.Stock,
                   Image = i.Image,
                   CategoryId = i.CategoryId
               }).OrderByDescending(i=> i.Id).ToList();

            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            return View(db.products.Find(id));
        }
        public ActionResult List(int? id)
        {
            var urunler = db.products
               .Where(i => i.IsApproved)
               .Select(i => new ProductModel()
               {
                   Id = i.Id,
                   Name = i.Name.Length > 50 ? i.Name.Substring(0, 50) + "..." : i.Name,
                   Description = i.Description.Length > 80 ? i.Description.Substring(0, 80) + "..." : i.Description,
                   Price = i.Price,
                   Stock = i.Stock,
                   Image = i.Image,
                   CategoryId = i.CategoryId
               }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(db.Categories.ToList());
        }
    }
}