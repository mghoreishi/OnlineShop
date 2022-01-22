using System.Collections.Generic;

namespace _01_OnlineShopQuery.Contracts.ProductCategory
{
    public interface IProductCategoryQuery
    {
        ProductCategoryQueryModel GetProductCategoryWithProducstsBy(string slug, int currentPage, int pageSize);
        List<ProductCategoryQueryModel> GetProductCategories();
        List<ProductCategoryQueryModel> GetProductCategoriesWithProducts();
        int GetCountProductCategoryWithProducstsBy(string slug);
    }
}
