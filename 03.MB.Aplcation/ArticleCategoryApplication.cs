using _00.Framework.Infrastructure;
using _01.MB.Domin.ArticleCategoryAgg;
using _01.MB.Domin.ArticleCategoryAgg.Servives;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.MB.Aplcation
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IArticleCategoryRepository articleCategoryRepository;
        private readonly IArticleCategoryValidatorService articleCategoryValidatorService;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository, IArticleCategoryValidatorService articleCategoryValidatorService, IUnitOfWork unitOfWork)
        {
            this.articleCategoryRepository = articleCategoryRepository;
            this.articleCategoryValidatorService = articleCategoryValidatorService;
            this.unitOfWork = unitOfWork;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategoris = articleCategoryRepository.GetAll();

            return articleCategoris.Select(x => new ArticleCategoryViewModel
            {
                Id = x.Id,
                Title = x.Title,
                IsDeleted = x.IsDeleted,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).OrderByDescending(x => x.Id).ToList();

        }

        public void Create(CreateArticleCategory command)
        {
            unitOfWork.BeginTran();
            var articleCategory = new ArticleCategory(command.Title, articleCategoryValidatorService);
            articleCategoryRepository.Creat(articleCategory);
            unitOfWork.CommitTran();
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);
            //articleCategoryRepository.SaveChanges();
        }

        public RenameArticleCategory Get(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }

        public void Remove(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            articleCategory.Remove();
            //articleCategoryRepository.SaveChanges();
        }

        public void Activate(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            articleCategory.Activate();
            //articleCategoryRepository.SaveChanges();
        }
    }
}
