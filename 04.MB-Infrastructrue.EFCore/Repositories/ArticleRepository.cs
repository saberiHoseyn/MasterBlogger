﻿using _01.MB.Domin.ArticleAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext context;

        public ArticleRepository(MasterBloggerContext context)
        {
            this.context = context;
        }

        public List<ArticleViewModel> GetList()
        {
            return context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                ArticleCategory = x.ArticleCategory.Title,
                IsDeleted = x.IsDeleted,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).OrderByDescending(x => x.Id).ToList();
        }

        public void CreateAndSave(Article entity)
        {
            context.Articles.Add(entity);
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
