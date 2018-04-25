using SportStoreMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreMVC.Domain.Concrete
{
    public class FormsAuthProvider:IAuthProvider
    {
        public bool Authenticate(string username,string password)
        {
            // bool result = FormsAuthenciation.Authenticate(username, password);
            return true;
        }
    }
}
