using _01.MB.Domin.CommentAgg;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext context;

        public CommentRepository(MasterBloggerContext context)
        {
            this.context = context;
        }
    }
}
