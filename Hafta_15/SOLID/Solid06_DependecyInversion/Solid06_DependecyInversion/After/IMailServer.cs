using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid06_DependecyInversion.After
{
    public interface IMailServer
    {
        void Send(string to, string body);
    }
}
