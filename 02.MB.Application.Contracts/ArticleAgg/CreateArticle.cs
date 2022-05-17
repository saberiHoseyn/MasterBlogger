using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MB.Application.Contracts.ArticleAgg
{
    public class CreateArticle
    {
        public string Title { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public long ArticleCategoryId { get; set; }
    }
}
