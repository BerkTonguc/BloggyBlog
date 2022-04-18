using BloggyBlog.Data.Abstract;
using BloggyBlog.Data.Concrete;
using BloggyBlog.Data.Concrete.EntityFramework.Contexts;
using BloggyBlog.Services.Abstract;
using BloggyBlog.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggyBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<BloggyBlogContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            return serviceCollection;

        }
    }
}
