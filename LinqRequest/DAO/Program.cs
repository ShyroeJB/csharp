using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAO
{
    static class Program
    {
        static void Main(string[] args)
        {
            //setup the DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IArticleDao, ArticleDao>()
                .BuildServiceProvider();

            var articleDao = serviceProvider.GetRequiredService<IArticleDao>();

            Console.WriteLine("Get one Article");
            var article = articleDao.GetArticlebyName("One Plus");
            Console.WriteLine(article.ToString());

            Console.WriteLine("\nGet all Articles");
            foreach (var art in articleDao.GetArticles())
            {
                Console.WriteLine(art.ToString());
            }

            Console.WriteLine("\nGet Quantity and Price");
            (var quantity, var price) = articleDao.GetArticleQuantityAndPrice("PC Gamer");
            Console.WriteLine($"Quantity : {quantity}, Price : {price}");

            Console.WriteLine("\nGet Quantity and Price Tuple");
            var tuple = articleDao.GetArticleQuantityAndPriceTuple("PC Gamer");
            Console.WriteLine($"Quantity : {tuple.Item1}, Price : {tuple.Item2}");

            Console.WriteLine("\nGet Info");
            Console.WriteLine(articleDao.GetInformationArticle());
        }
    }
}
