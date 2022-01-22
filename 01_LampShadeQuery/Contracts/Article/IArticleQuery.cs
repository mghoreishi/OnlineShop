using System.Collections.Generic;

namespace _01_OnlineShopQuery.Contracts.Article
{
    public interface IArticleQuery
    {
        List<ArticleQueryModel> LatestArticles(int currentPage, int pageSize);
        ArticleQueryModel GetArticleDetails(string slug);
    }
}
