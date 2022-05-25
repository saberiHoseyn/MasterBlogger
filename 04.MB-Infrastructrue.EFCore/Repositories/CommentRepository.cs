using _00.Framework.Infrastructure;
using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.CommentAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class CommentRepository : BaseRepository<long, Comment>, ICommentRepository
    {
        private readonly MasterBloggerContext context;

        public CommentRepository(MasterBloggerContext context) : base(context)
        {
            this.context = context;
        }

        public List<CommentViewModel> GetList()
        {
            return context.Comments.Include(x => x.Article).Select(x => new CommentViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Status = x.Status,
                Message = x.Message,
                Article = x.Article.Title,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
            }).ToList();
        }
    }
}
