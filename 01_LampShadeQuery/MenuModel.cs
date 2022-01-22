using _01_OnlineShopQuery.Contracts.ArticleCategory;
using _01_OnlineShopQuery.Contracts.ProductCategory;
using System.Collections.Generic;

namespace _01_OnlineShopQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
