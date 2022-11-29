using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    public interface IDataResult<out T> : IResult
    {

        public T Data { get; }
        //new DataResult<Categroy>(ResultStatus.Success, category)
        //new DataResult<IList<Categroy>>(ResultStatus.Success, categories)

    }
}
