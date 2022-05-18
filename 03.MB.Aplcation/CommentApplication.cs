using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.CommentAgg;

namespace _03.MB.Aplcation
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository commentRepository;

        public CommentApplication(ICommentRepository commentRepository)
        {
            this.commentRepository = commentRepository;
        }
    }
}
