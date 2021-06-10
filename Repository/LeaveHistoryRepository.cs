using Leave_management.Contracts;
using Leave_management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Data.LeaveHistory entity)
        {
            _db.LeaveHistories.Add(entity);
            return Save();

        }

        public bool Delete(Data.LeaveHistory entity)
        {
            _db.LeaveHistories.Remove(entity);
             return Save();
        }

        public ICollection<Data.LeaveHistory> FindAll()
        {
            return _db.LeaveHistories.ToList();
          
        }

        public Data.LeaveHistory FindById(int id)
        {
            return _db.LeaveHistories.Find(id);
           
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;
        }

        public bool Update(Data.LeaveHistory entity)
        {
            _db.LeaveHistories.Update(entity);
            return Save();
        }
    }
}
