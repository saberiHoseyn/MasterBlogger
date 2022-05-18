using _01.MB.Domin.ArticleAgg;
using _01.MB.Domin.ArticleAgg.Services;
using _01.MB.Domin.ArticleCategoryAgg;
using _01.MB.Domin.ArticleCategoryAgg.Servives;
using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using _02.MB.Application.Contracts.CommentAgg;
using _03.MB.Aplcation;
using _04.MB_Infrastructrue.EFCore;
using _04.MB_Infrastructrue.EFCore.Repositories;
using _06.MB.Infrastructure.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Core
{
    public class Bootestraper
    {
        public static void Config(IServiceCollection services, string ConnectionString)
        {
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryValidatorService, ArticleCategoryValidatorService>();

            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleValidatorService, ArticleValidatorService>();

            services.AddTransient<ICommentApplication, CommentApplication>();
            services.AddTransient<ICommentRepository, CommentRepository>();

            services.AddTransient<IArticleQuery, ArticleQuery>();

            services.AddDbContext<MasterBloggerContext>(option =>
              option.UseSqlServer(ConnectionString));
        }
    }
}
