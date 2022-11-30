using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services.Extensions
{
    public static class ServiceCollectionExtensions 
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddDbContext<BlogAppContext>();
            servicesCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            servicesCollection.AddScoped<ICategoryService, CategoryManager>();
            servicesCollection.AddScoped<IArticleService, ArticleManager>();
            return servicesCollection;
        }
    }
}
