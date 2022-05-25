using _01.MB.Domin.ArticleCategoryAgg.Exceptions;

namespace _01.MB.Domin.ArticleAgg.Services
{
    public class ArticleValidatorService : IArticleValidatorService
    {
        private readonly IArticleRepository articleRepository;

        public ArticleValidatorService(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public void CheckThatThisRecordAlreadyExists(string title)
        {
            if (articleRepository.Exists(x => x.Title == title))
                throw new DuplicatedRecordException("this record already exists in database!");
        }
    }
}
