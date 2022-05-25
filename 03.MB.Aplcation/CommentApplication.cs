using _00.Framework.Infrastructure;
using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.CommentAgg;
using System.Collections.Generic;

namespace _03.MB.Aplcation
{
    public class CommentApplication : ICommentApplication
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ICommentRepository commentRepository;

        public CommentApplication(ICommentRepository commentRepository, IUnitOfWork unitOfWork)
        {
            this.commentRepository = commentRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(AddComment comment)
        {
            unitOfWork.BeginTran();
            var entity = new Comment(comment.Name, comment.Email, comment.Message, comment.ArticleId);
            commentRepository.Creat(entity);
            unitOfWork.CommitTran();
        }

        public void Cancel(long id)
        {
            unitOfWork.BeginTran();
            var comment = commentRepository.Get(id);
            comment.Cancel();
            unitOfWork.CommitTran();
        }

        public void Confirm(long id)
        {
            unitOfWork.BeginTran();
            var comment = commentRepository.Get(id);
            comment.Confirm();
            unitOfWork.CommitTran();
        }

        public List<CommentViewModel> GetList()
        {
            return commentRepository.GetList();
        }
    }
}
