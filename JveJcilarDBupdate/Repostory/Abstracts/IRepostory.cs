using JveJcilarDBupdate.Data;
using JveJcilarDBupdate.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JveJcilarDBupdate.Abstracts.Repostory
{
    public interface IRepostory<T> where T : CafeBase
    {
        T GetById(int id);
        IQueryable<T> Get(Func<T, bool> predicate = null);
        void Add(T entity, bool isSaveLater = false);
        void Remove(T entity, bool isSaveLater = false);
        void Update(T entity, bool isSaveLater = false);
        int Save();
    }
}
