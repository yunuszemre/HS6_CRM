using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.Entities.Concreate
{
    using Abstract;
    public class UserAccount : IEntity
    {
        /// <summary>
        /// Database unque ID
        /// </summary>
        public int UserAccountId { get; set; }
        /// <summary>
        /// Kullanıcı Adı   
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Şifre
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Gerçek adı
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// İlk kayıt tarihi
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// Kaydın son güncellenme tarihi
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
