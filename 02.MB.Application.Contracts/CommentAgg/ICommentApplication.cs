﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MB.Application.Contracts.CommentAgg
{
    public interface ICommentApplication
    {
        void Add(AddComment comment);
        List<CommentViewModel> GetList();
    }
}
