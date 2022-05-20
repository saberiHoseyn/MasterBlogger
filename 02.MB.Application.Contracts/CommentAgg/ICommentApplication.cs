using System.Collections.Generic;

namespace _02.MB.Application.Contracts.CommentAgg
{
    public interface ICommentApplication
    {
        void Add(AddComment comment);
        List<CommentViewModel> GetList();
        void Confirm( long id);
        void Cancel( long id);
    }
}
