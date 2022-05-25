using _00.Framework.Infrastructure;
using _02.MB.Application.Contracts.CommentAgg;
using System.Collections.Generic;

namespace _01.MB.Domin.CommentAgg
{
    public interface ICommentRepository : IBaseRepository<long, Comment>
    {
        List<CommentViewModel> GetList();
    }

}
