using _01.MB.Domin.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext context;

        public ArticleCategoryRepository(MasterBloggerContext context)
        {
            this.context = context;
        }

        public void Add(ArticleCategory entity)
        {
            context.ArticleCategories.Add(entity);
            SaveChanges();
        }

        public bool Exists(string title)
        {
            return context.ArticleCategories.Any(x => x.Title == title);
        }

        public ArticleCategory Get(long id)
        {
            return context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleCategory> GetAll()
        {
            return context.ArticleCategories.OrderByDescending(x => x.Id).ToList();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
