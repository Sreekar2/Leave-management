using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Contracts
{
    public interface IRepositoryBase<T> where T:class
    {
        // what ever the class(T) we pass in here, the goal is to retrieve all the data from the DB. It is similar to Select * from .. 
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
    }
}
