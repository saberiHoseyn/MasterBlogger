using _01.MB.Domin.ArticleCategoryAgg;
using _01.MB.Domin.ArticleCategoryAgg.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MB.Domin.ArticleCategoryAgg.Servives
{
    public interface IArticleCategoryValidatorService
    {
        void CheckThatThisRecordAlreadyExists(string title);
    }

    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository articleCategoryRepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (articleCategoryRepository.Exists(title))
            {
                throw new DuplicatedRecordException("this record already exists in database!!");
            }
        }
    }
}
