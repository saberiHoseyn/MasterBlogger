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
        public int Like { get; private set; }
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

            Like = 0;
            Img = img;
            Title = title;
            Content = content;
            IsDeleted = false;
            Comments = new List<Comment>();
            ShortDescription = shortDescription;
            ArticleCategoryId = articleCategoryId;
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

        public void AddLike()
        {
            Like++;
        }
        public void RemoveLike()
        {
            Like--;
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
