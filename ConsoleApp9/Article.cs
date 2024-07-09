using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }

        public List<Comment> Comments { get; set; }

        public Article(int id, string name, string text, User author)
        {
            Id = id;
            Name = name;
            Text = text;
            Author = author;
            Comments = new List<Comment>();
        }
    }
}
