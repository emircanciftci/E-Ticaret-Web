using GiyimETicaret.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace GiyimETicaret.UI.Controllers
{
    public class ProductsController : BaseController
    {
        // GET: Products
        public ActionResult Index(int ID)
        {
            return View(service.ProductsService.GetAll().Where(x=>x.ID == ID).ToList());
        }
    }
}