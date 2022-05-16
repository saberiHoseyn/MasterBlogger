using _01.MB.Domin.ArticleCategoryAgg;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using _03.MB.Aplcation;
using _04.MB_Infrastructrue.EFCore;
using _04.MB_Infrastructrue.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;

namespace MB.Infrastructure.Core
{
    public class Bootestraper
    {
        public static void Config(IServiceCollection services, string ConnectionString)
        {
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddDbContext<MasterBloggerContext>(option =>
              option.UseSqlServer(ConnectionString));
        }
    }
}
