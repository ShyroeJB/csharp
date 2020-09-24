using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class ArticleDao : IArticleDao
    {
        public List<Article> Articles { get; }

        public ArticleDao()
        {
            Articles = Utils.GetArticles();
        }

        public ArticleDao(List<Article> article)
        {
            Articles = article;
        }

        public Article GetArticlebyName(string name)
        {
            return Articles.FirstOrDefault(art => art.Name.Equals(name));
        }

        public IList<Article> GetArticles()
        {
            return Articles;
        }

        public (int, double) GetArticleQuantityAndPrice(string name)
        {
            var article = Articles.FirstOrDefault(art => art.Name.Equals(name));
            return (article.Quantity, article.Price);
        }

        public Tuple<int, double> GetArticleQuantityAndPriceTuple(string name)
        {
            var article = Articles.FirstOrDefault(art => art.Name.Equals(name));
            return new Tuple<int, double>(article.Quantity, article.Price);
        }

        public string GetInformationArticle()
        {
            return $"Article Information : \n" +
                $"Total Article : {Articles.Count()}\n" +
                $"Total Price Article : {Articles.Sum(art => art.Price)}\n" +
                $"Average Price : {Articles.Average(art => art.Price)}\n" +
                $"Quantity Min : {Articles.Min(art => art.Quantity)}\n" +
                $"Quantity Max : {Articles.Max(art => art.Quantity)}";
        }
    }
}
