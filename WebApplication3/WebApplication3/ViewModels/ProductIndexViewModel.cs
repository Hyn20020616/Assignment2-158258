using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class ProductIndexViewModel
    {
        public IPagedList<Product> Products { get; set; }
        // public IQueryable<Product> Products { get; set; }
        public string Search { get; set; } //replaces the ViewBag.Search
        public IEnumerable<CategoryWithCount> CatsWithCount { get; set; } // will hold all of the CategoryWithCount items to be used inside the select control in the view.
        public string Category { get; set; } //will be used as the name of the select control in the view
        public string SortBy { get; set; }
        public Dictionary<string, string> Sorts {get; set;}
        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
    public class CategoryWithCount
        {
            public int ProductCount { get; set; }
            public string CategoryName { get; set; }
            public string CatNameWithCount
            {
                get
                {
                    return CategoryName + " (" + ProductCount.ToString() + ")";
                }
            }
        }
    } 
}