using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.BL.Concreate
{
    using Abstract;
    using DAL.Abstract;
    using DAL.Concreate;
    using HS6_CRM.Entities.Concreate;

    public class UserAccountService : IUserAccountBusinnes
    {
        IUserAccountRepository userRepo;
        public UserAccountService()
        {
            userRepo = new UserAccountRepository();
        }
        public bool Delete(int id)
        {
            return userRepo.Delete(id);
        }

        public List<UserAccount> GetAll()
        {
            return userRepo.GetAll();
        }

        public UserAccount GetById(int id)
        {
            return userRepo.GetById(id);
        }

        public UserAccount GetUser(string username, string password)
        {
            return userRepo.GetUser(username, password);
        }

        public void Insert(UserAccount item)
        {
            userRepo.Insert(item);
        }

        public void Update(UserAccount item)
        {
            userRepo.Update(item);
        }

    }
}
