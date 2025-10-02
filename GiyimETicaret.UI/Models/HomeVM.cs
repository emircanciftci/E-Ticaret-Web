using GiyimETicaret.BLL.Repository.Entity;
using GiyimETicaret.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiyimETicaret.UI.Models
{
    public class HomeVM
    {
        public List<Products> ProductsList { get; set; }
        public List<Products> ProductsNewList { get; set; }
        public List<ProductImages> ProductImagesList { get; set; }
        public List<Categories> CategoriesList { get; set; }
        public List<Categories> CategoriesNewList { get; set; }
        public List<Products> ProductBestList { get; set; }
        public List<Discounts> DiscountsList { get; set; }

    }
}