using _01_OnlineShopQuery.Contracts.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace ServiceHost.Pages
{
    public class SearchModel : PageModel
    {
        public string Value;
        public ProductQuerySearchModel ProductSearchModel;
        private readonly IProductQuery _productQuery;

        public SearchModel(IProductQuery productQuery)
        {
            _productQuery = productQuery;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int CountPages { get; set; }
        public int PageSize { get; set; } = 2;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));

        public void OnGet(string value)
        {
            Value = value;
            ProductSearchModel = _productQuery.Search(value,CurrentPage,PageSize);
            Count = ProductSearchModel.TotalCount;
            CountPages = Count / PageSize == 0 ? 1 : Count / PageSize;
        }
    }
}
