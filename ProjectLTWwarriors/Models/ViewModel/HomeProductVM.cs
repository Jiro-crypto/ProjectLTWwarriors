using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLTWwarriors.Models.ViewModel
{
    public class HomeProductVM
    {
        public string SearchTerm { get; set; }

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 5;

        public List<Products> FeaturedProducts { get; set; }

        public IPagedList<Products> NewProducts { get; set; }
    }
}