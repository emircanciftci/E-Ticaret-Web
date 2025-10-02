using GiyimETicaret.DAL.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GiyimETicaret.UI.Models
{
    public class CategoriesVM
    {
        public List<Products> ProductsList { get; set; }
        public List<Products> ProductsNewList { get; set; }
        public List<Discounts> DiscountsList { get; set; }
        public string CategoriesName { get; set; }
    }
}