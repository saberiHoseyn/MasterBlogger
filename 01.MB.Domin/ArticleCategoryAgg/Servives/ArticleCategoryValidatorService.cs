using _01.MB.Domin.ArticleCategoryAgg.Exceptions;

namespace _01.MB.Domin.ArticleCategoryAgg.Servives
{
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
