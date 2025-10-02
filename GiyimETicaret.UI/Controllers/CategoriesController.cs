using GiyimETicaret.DAL.DB;
using GiyimETicaret.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace GiyimETicaret.UI.Controllers
{
    public class CategoriesController : BaseController
    {
        // GET: Categories
        public ActionResult Index(int ID)
        {
            CategoriesVM VM = new CategoriesVM();
            VM.ProductsList = service.ProductsService.GetAll().Where(x => x.CategoryID == ID).ToList();
            VM.DiscountsList = service.DiscountsService.GetAll().ToList();
            VM.ProductsNewList = VM.ProductsList.Where(x=>x.UpdatedAt >= DateTime.Today.AddDays(-7)).ToList();
            VM.CategoriesName = service.CategoriesService.Find(ID).Name;
            return View(VM);
        }
    }
}