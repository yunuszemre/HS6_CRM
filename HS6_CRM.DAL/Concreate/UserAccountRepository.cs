using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.DAL.Concreate
{
    using DB;
    using Abstract;
    using Entities.Concreate;
    public class UserAccountRepository : IUserAccountRepository
    {
        FakeDB _context;
        public UserAccountRepository()
        {
            _context = new FakeDB();
        }
        public bool Delete(int id)
        {
            bool result = false;
            var entity = _context.UserAccount.FirstOrDefault(t0 => t0.UserAccountId == id);
            if (entity != null)
            {
                _context.UserAccount.Remove(entity);
                result = true;
            }
            return result;
        }

        public List<UserAccount> GetAll()
        {
            return _context.UserAccount;
        }

        public UserAccount GetById(int id)
        {
            return _context.UserAccount.FirstOrDefault(t0 => t0.UserAccountId == id);
        }

        public UserAccount GetUser(string username, string password)
        {
            return _context.UserAccount.FirstOrDefault(t0 => t0.UserName == username && t0.Password == password);
        }

        public void Insert(UserAccount item)
        {
            item.UserAccountId = _context.NextUserAccountId();
            item.RecordDate = DateTime.Now; //Kayıt tarihi
            _context.UserAccount.Add(item);
        }

        public void Update(UserAccount item)
        {
            var entity = _context.UserAccount.FirstOrDefault(t0 => t0.UserAccountId == item.UserAccountId);
            if (entity != null)
            {
                //paramtre olarak dışarıdan gelen parametreleri DB deki kayıt ile dğiştirdim

                entity.FullName = item.FullName;
                entity.UserName = item.UserName;
                entity.ModifiedDate = DateTime.Now;
                entity.Password = item.Password;
            }
        }
    }
}
