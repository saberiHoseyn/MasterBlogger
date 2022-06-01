using System;

namespace MB.Infrastructure.Context
{
    public interface IUserLikeManager
    {
        bool AddLike(long id);
        bool HasLikeUserAny(long id);
    }
}
