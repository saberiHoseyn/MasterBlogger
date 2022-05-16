using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MB.Domin.ArticleAgg
{
    public class Article
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string Img { get; private set; }

        protected Article()
        {
        }

        public Article(string title, string shortDescription, string content, string img)
        {
            Title = title;
            ShortDescription = shortDescription;
            Content = content;
            Img = img;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
    }
}
