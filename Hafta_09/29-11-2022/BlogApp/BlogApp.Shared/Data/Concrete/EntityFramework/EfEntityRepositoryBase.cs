using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity: class, IEntity, new()
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity); //await asenkron metotlarda kullanılır. Bu metot asnyc dedik
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
           return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            //Burada contextimize erişip hangi entity ile çalışacksak o entityi IQueryable tipinde alıyoruz ki sonrasında arkasına where include gibi yapıları duruma göre ekleyebilelim.

            if (predicate!=null)
            //Bu metotda gelen 1. parametre yani predicate null değilse, koşul belirtilmiştir. Bu durumda o koşulu (preciate) if içinde Where ile query üzerine ekliyoruz. Eğer predicate null ise  query üzerine where ile ilgili bir şey eklenmesine gerek yok.
            {
                query=query.Where(predicate);  
            }

            if (includeProperties.Any())
            //Eğer 2.parametremiz olan includeProperties dizisinde eleman varsa bu dizi içinde dönerek her elemanı query'e ekliyoruz.Ki her eleman bir Include taşıyor. Burası da bittiğinde artık ToList yapılabilir halde bir query elimizde olacak.
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);//
                }
            }

            return await query.ToListAsync();
            // Artık ToListAsync yapılabilecek query elimizde. Biz de geriye döndüreceğimiz. query'yi ToListAsync ile Listeye çeviriyoruz çünkü bu metot geriye bir Liste döndürmesi gerekiyor.
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)//PARAMS:birden fazla parametre de alabilir demek.
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            query= query.Where(predicate);// Koşulu olmadığı için böyle yaptık. Null olma durumu yok .
           
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync();//GetAsync motunda tek birtane bilgi çağırdığımız için liste olarak gelmesine gerek yok. Ama GetALLAsync'da toplu çağırım yaptığımız için tolist demiştik.

            //FirstOrDefault : Hangi bilgiyi istiyorsak listede İLK karşılaştığını getirir.
            //SingleOrDefault : 1 tane kayıt olduğunu bildiğimizde tek birşey döndürdüğünden emin olmak istiyorsak kullanırız. Mesela ID gibi.
        }

        
    }
}
