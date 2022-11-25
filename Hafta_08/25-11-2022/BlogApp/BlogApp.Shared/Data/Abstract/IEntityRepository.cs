using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,params Expression<Func<T, object>>[] includeProperties);//Not-1,Not-2

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);//Not-3
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task <int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}


//* Not-1 ******
// Örneğin ID si 12 olan kaydı getirmek istiyoruz.
//var article = repository.GetAsync(x=>x.Id==12)
//User user = repository.GetAsync(x=>x.Name == "mert")


// *****NOT-2******
// Örneğin Id'si 12 olan Article'ı User ve Commentleryile birlikte getirmek istiyoruz.
// Article article = repositoryArticle.GetAsync(x=>x.Id==12, y=>y.User, y=>y.Comments, z=>z.Role)

// *****NOT-3****
// Örneğin tüm ARticle'ları listelemek istiyoruz.
// var articles = repositoryArticle.GetAllAsync();
//Örneğin DotNet Category'sindeki tüm Article'ları listelemek istiyoruz
// car articles = repositoryArticle.GetAllAsync(a=>a.Category.Name=="DotNet", c=>c.Category)
//Örneğin Id'si 12 olan Article'in yorumlarını getirmek istiyoruz
// var comments = repositoryComment.GetAllAsync(c=c.ArticleId==12)