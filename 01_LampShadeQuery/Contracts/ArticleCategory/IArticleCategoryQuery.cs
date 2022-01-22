using System.Collections.Generic;

namespace _01_OnlineShopQuery.Contracts.ArticleCategory
{
    public interface IArticleCategoryQuery
    {
        ArticleCategoryQueryModel GetArticleCategory(string slug, int currentPage, int pageSize);
        List<ArticleCategoryQueryModel> GetArticleCategories();
    }
}
