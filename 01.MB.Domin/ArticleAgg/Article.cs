using _00.Framework.Domin;
using _01.MB.Domin.ArticleCategoryAgg;
using _01.MB.Domin.CommentAgg;
using System;
using System.Collections.Generic;

namespace _01.MB.Domin.ArticleAgg
{
    public class Article : DominBase<long>
    {
        #region properties
        public string Title { get; private set; }
        public string ShortDescription { get; private set; }
        public string Content { get; private set; }
        public bool IsDeleted { get; private set; }
        public string Img { get; private set; }
        public long ArticleCategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
        public ICollection<Comment> Comments { get; private set; }

        #endregion

        #region constroctors
        protected Article()
        {
        }

        public Article(string title, string shortDescription, string content, string img, long articleCategoryId)
        {
            Validate(title, articleCategoryId);

            Title = title;
            ShortDescription = shortDescription;
            Content = content;
            Img = img;
            ArticleCategoryId = articleCategoryId;
            IsDeleted = false;
            Comments = new List<Comment>();
        }
        #endregion


        public void Edit(string title, string shortDescription, string content, string img, long articleCategoryId)
        {
            Validate(title, articleCategoryId);

            Title = title;
            ShortDescription = shortDescription;
            Content = content;
            Img = img;
            ArticleCategoryId = articleCategoryId;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }

        private static void Validate(string title, long articleCategoryId)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException();

            if (articleCategoryId == 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
