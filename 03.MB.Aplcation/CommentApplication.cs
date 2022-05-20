using _01.MB.Domin.CommentAgg;
using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.CommentAgg;
using System.Collections.Generic;

namespace _03.MB.Aplcation
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public void Add(AddComment comment)
        {
            var entity = new Comment(comment.Name, comment.Email, comment.Message, comment.ArticleId);
            commentRepository.CreateAndSave(entity);
        }

        public void Cancel(long id)
        {
            var comment = commentRepository.Get(id);
            comment.Cancel();
            commentRepository.Save();

        }

        public void Confirm(long id)
        {
            var comment = commentRepository.Get(id);
            comment.Confirm();
            commentRepository.Save();
        }

        public List<CommentViewModel> GetList()
        {
            return commentRepository.GetList();
        }
    }
}
