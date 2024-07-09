using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Сomment
    {
        public string Text { get; set; }
        public User Author {  get; set; }
        public int Rating { get; set; }

        public Comment(string text, User author, int rating)
        {
            Text = text;
            Author = author;
            Rating = rating;
        }
    }
}
