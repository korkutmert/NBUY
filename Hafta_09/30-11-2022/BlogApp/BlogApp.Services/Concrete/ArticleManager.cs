using BlogApp.Data.Abstract;
using BlogApp.Entities.Concrete;
using BlogApp.Entities.Dtos;
using BlogApp.Services.Abstract;
using BlogApp.Shared.Utilities.Result.Abstract;
using BlogApp.Shared.Utilities.Result.ComplexTypes;
using BlogApp.Shared.Utilities.Result.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlogApp.Services.Concrete
{
    public class ArticleManager : IArticleService


    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> Add(ArticleAddDto articleAddDto, string createdByName)
        {
            await _unitOfWork.Articles.AddAsync(new Article // burda add yapınca contexe bunları yerleştirecek.
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                Thumbnail = articleAddDto.Thumbnail,
                Date = articleAddDto.Date,
                SeoAuthor = articleAddDto.SeoAuthor,
                SeoDescription = articleAddDto.SeoDescription,
                SeoTags = articleAddDto.SeoTags,
                IsActive = articleAddDto.IsActive,
                CategoryId = articleAddDto.CategoryId,
                CreatedDate = DateTime.Now,
                CreatedByName = createdByName,
                ModifiedDate = DateTime.Now,
                ModifiedByName = createdByName,
                IsDeleted = false
            }
                ).ContinueWith(t => _unitOfWork.SaveAsync()); // bu da kaydeder daha performanslı bir şekilde çalışır.
            return new Result(ResultStatus.Success, $"{articleAddDto.Title} başlıklı makale başarıyla eklenmiştir.");
          //  await _unitOfWork.SaveAsync();// Yukarıdaki işlemler bittikten sonra save yapıp veritabanına kaydediyoruz.
        }

        public Task<IResult> Delete(int articleId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ArticleDto>> Get(int articleId)
        {
            var article = await _unitOfWork.Articles.GetAsync(a=>a.Id==articleId);
            if (article!=null)
            {
                return new DataResult<ArticleDto>(ResultStatus.Success, new ArticleDto
                {
                    Article=article,
                    ResultStatus= ResultStatus.Success,
                });
            }
            return new DataResult<ArticleDto>(ResultStatus.Error,"Bulunamadı",null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAll()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(null, c=>c.Category, u=>u.User);
            if (articles.Count>0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles, 
                    ResultStatus= ResultStatus.Success,
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error,"Bulunamadı",null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeleted()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a=>!a.IsDeleted);
            if (articles.Count>0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus= ResultStatus.Success,
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Bulunamadı", null);
        }

        public async Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAnActive()
        {
            var articles = await _unitOfWork.Articles.GetAllAsync(a => !a.IsDeleted && a.IsActive);
            if (articles.Count>0)
            {
                return new DataResult<ArticleListDto>(ResultStatus.Success, new ArticleListDto
                {
                    Articles = articles,
                    ResultStatus= ResultStatus.Success,
                });
            }
            return new DataResult<ArticleListDto>(ResultStatus.Error, "Bulunamadı", null);
        }

        public Task<IResult> HardDelete(int articleId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
