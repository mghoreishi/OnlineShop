using _01_OnlineShopQuery.Contracts.ProductCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace ServiceHost.Pages
{
    public class ProductCategoryModel : PageModel
    {
        public ProductCategoryQueryModel ProductCategory;
        private readonly IProductCategoryQuery _productCategoryQuery;

        public ProductCategoryModel(IProductCategoryQuery productCategoryQuery)
        {
            _productCategoryQuery = productCategoryQuery;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int CountPages { get; set; }
        public int PageSize { get; set; } = 3;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));


        public void OnGet(string id)
        {
            ProductCategory = _productCategoryQuery.GetProductCategoryWithProducstsBy(id, CurrentPage, PageSize);
            Count = _productCategoryQuery.GetCountProductCategoryWithProducstsBy(id);
            CountPages = Count / PageSize == 0 ? 1 : Count / PageSize;
        }
    }
}
