using System.Collections.Generic;

namespace DAO
{
    public static class Utils
    {
        public static List<Article> GetArticles()
        {
            return new List<Article>()
            {
                new Article("One Plus", 400, 100),
                new Article("PC Gamer", 2000, 10),
                new Article("Clavier Logitech", 200.50, 50)
            };
        }
    }
}
