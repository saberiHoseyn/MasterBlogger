using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MB.Application.Contracts.CommentAgg
{
    public class AddComment
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public long ArticleId { get; set; }
        public string Message { get; set; }
    }
}
