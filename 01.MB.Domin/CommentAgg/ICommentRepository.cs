using _02.MB.Application.Contracts.CommentAgg;
using System.Collections.Generic;

namespace _01.MB.Domin.CommentAgg
{
    public interface ICommentRepository
    {
        void CreateAndSave(Comment entity);
        List<CommentViewModel> GetList();
        void Save();
    }
}
