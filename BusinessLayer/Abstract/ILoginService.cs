using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ILoginService
    {
        Admin Auth(string username, string password);
        Writer GetWriter(string username, string password);
    }
}
