using _01.MB.Domin.ArticleAgg;
using System;

namespace _01.MB.Domin.CommentAgg
{
    public class Comment
    {
        #region Properties
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public DateTime CreationDate { get; private set; }
        public int Status { get; private set; }
        public Article Article { get; set; }
        public long ArticleId { get; set; }
        #endregion

        protected Comment()
        {
        }

        public Comment(string name, string email, string message, long articleId)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId = articleId;
            Status = Statuses.New;
            CreationDate = DateTime.Now;
        }
    }
}
