using BlogApp.Shared.Utilities.Result.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; } //ResultStatus.Error VB.
        public string Message { get; }//Hata mesajları bununla taşınacak.
        public Exception Exception { get; }//Hataları(exceptions) bununla taşıyacağız.
    }
}
