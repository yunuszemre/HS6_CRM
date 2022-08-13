using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS6_CRM.DAL.Abstract
{
    public interface IRepository<T>
    {
        //CRUD => Create, Read, Update, Delete

        //Create
        void Insert(T item);
        //Update
        void Update(T item);
        //Delete
        bool Delete(int id);
        //Select
        T GetById(int id);
        //All data
        List<T> GetAll();
    }
}
