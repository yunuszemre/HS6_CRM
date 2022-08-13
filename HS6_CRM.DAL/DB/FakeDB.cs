using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.DAL.DB
{
    using Entities.Concreate;
    public class FakeDB
    {
        private static int _UserAccountId = 0;
        /// <summary>
        /// Kullanıcı tablosu
        /// </summary>
        List<UserAccount> UserAccountList;

        public FakeDB()
        {
            //init
            
            
            UserAccountList = new List<UserAccount>();
            seedData();
        }
        public List<UserAccount> UserAccount { get { return UserAccountList; } }


        /// <summary>
        /// DB ayağa kaltığında içinde test edileiblir bir data oluşması için
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void seedData()
        {
            UserAccount.Add(new UserAccount() { FullName = "Yunus Emre Teke", Password = "123", UserName = "admin", ModifiedDate = DateTime.Now,RecordDate = DateTime.Now ,UserAccountId = NextUserAccountId() });
        }

        public int NextUserAccountId()
        {
            return _UserAccountId + 1;
        }
    }
}
