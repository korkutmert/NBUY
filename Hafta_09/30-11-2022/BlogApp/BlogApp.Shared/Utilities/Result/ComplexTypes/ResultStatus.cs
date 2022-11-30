using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.ComplexTypes
{
    public enum ResultStatus//kendi tipimizi yaratıyoruz. 0-1-2-3 gibi değerler yazmak yerine succes info vb yazılarla yazmak için enum kullandık. Bu işe yarıyor.
    {
        Success = 0,
        Error = 1, // ResulStatus.Error
        Warning = 2,
        Info = 3

    }
}
