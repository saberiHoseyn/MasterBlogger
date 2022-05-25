using System;

namespace _01.MB.Domin.ArticleCategoryAgg.Exceptions
{
    public class DuplicatedRecordException : Exception
    {
        protected DuplicatedRecordException()
        {
        }

        public DuplicatedRecordException(string message) : base(message)
        {
        }
    }
}
