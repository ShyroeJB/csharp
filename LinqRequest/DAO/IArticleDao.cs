using System;
using System.Collections.Generic;

namespace DAO
{
    public interface IArticleDao
    {
        public Article GetArticlebyName(string name);
        public IList<Article> GetArticles();
        public (int, double) GetArticleQuantityAndPrice(string name);
        public Tuple<int, double> GetArticleQuantityAndPriceTuple(string name);
        public string GetInformationArticle();
    }
}
