using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Blog
    {
        private List<Article> articles;

        public Blog()
        {
            articles = new List<Article>();
        }

        public List<Article> GetAllArticles()
        {
            return articles;
        }

        public Article GetArticleById(int id)
        {
            return articles.FirstOrDefault(articles => articles.Id == id);
        }
    }
}