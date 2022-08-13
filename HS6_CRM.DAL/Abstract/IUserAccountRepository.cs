using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.DAL.Abstract
{
    using Entities.Concreate;
    public interface IUserAccountRepository : IRepository<UserAccount>
    {
        UserAccount GetUser(string username, string password);
    }
}
