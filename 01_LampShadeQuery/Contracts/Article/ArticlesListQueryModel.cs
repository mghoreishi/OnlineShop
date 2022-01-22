using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OnlineShopQuery.Contracts.Article
{
  public  class ArticlesListQueryModel
    {
        public List<ArticleQueryModel> Articles { get; set; }
        public int TotalCount { get; set; }
    }
}
