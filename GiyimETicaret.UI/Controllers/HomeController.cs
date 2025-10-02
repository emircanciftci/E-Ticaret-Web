using GiyimETicaret.DAL.DB;
using GiyimETicaret.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GiyimETicaret.UI.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.ProductsList = service.ProductsService.GetAll();
            vm.ProductImagesList = service.ProductImagesService.GetAll();
            vm.CategoriesList = service.CategoriesService.GetAll();
            vm.DiscountsList = service.DiscountsService.GetAll();

            ///Yeni gelen 1 haftalık ürünler
            vm.ProductsNewList = service.ProductsService.GetAll().Where(x => x.UpdatedAt >= DateTime.Now.AddDays(-7)).ToList();

            ///Yeni gelen 1 haftalık ürünlerin kategorileri
            List<int> Pro = service.ProductsService.GetAll().Where(x => x.UpdatedAt >= DateTime.Now.AddDays(-7)).Select(x=>x.CategoryID.Value).Distinct().ToList();
            ///Aynı kategoriyi teke indir
            vm.CategoriesNewList = service.CategoriesService.GetAll().Where(x => Pro.Contains(x.ID)).ToList();

            ///En çok satılan 10 ürün ID'lerini bulma
            List<int> ProductIDs = service.OrderItemsService.GetAll().GroupBy(x=>x.ProductID.Value).OrderByDescending(x=>x.Count()).Take(2).Select(x=>x.Key).ToList();
            ///En çok satılan 10 ürün listeleme
            vm.ProductBestList = service.ProductsService.GetAll().Where(x=>ProductIDs.Contains(x.ID)).ToList();

            return View(vm);
        }
    }
}