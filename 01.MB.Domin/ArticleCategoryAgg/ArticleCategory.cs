using _01.MB.Domin.ArticleAgg;
using _01.MB.Domin.ArticleCategoryAgg.Servives;
using System;
using System.Collections.Generic;

namespace _01.MB.Domin.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public ICollection<Article> Articles { get; private set; }


        public ArticleCategory(string title, IArticleCategoryValidatorService validatorService)
        {
            GuradAgainstEmptyTitle(title);
            validatorService.CheckThatThisRecordAlreadyExists(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
            Articles = new List<Article>();
        }

        public ArticleCategory()
        {
        }

        public void Rename(string title)
        {
            GuradAgainstEmptyTitle(title);
            Title = title;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }

        void GuradAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
