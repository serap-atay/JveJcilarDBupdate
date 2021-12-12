using JveJcilarDBupdate.Data;
using JveJcilarDBupdate.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JveJcilarDBupdate.Abstracts.Repostory
{
    public abstract class RepostoryBase<T> : IRepostory<T>
        where T : CafeBase
    {
        protected CafeContext _context;
        public DbSet<T> Table { get; protected set; }

        protected RepostoryBase()
        {
            _context = new CafeContext();
            Table = _context.Set<T>();
        }

        public virtual void Add(T entity, bool isSaveLater = false)
        {
            Table.Add(entity);
            if (!isSaveLater)
                this.Save();
        }

        public virtual IQueryable<T> Get(Func<T, bool> predicate = null)
        {
            return predicate == null ? Table : Table.Where(predicate).AsQueryable();
        }

        public virtual IQueryable<T> Get(String[] includes, Func<T, bool> predicate = null)
        {
            IQueryable<T> query = Table;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return predicate == null ? query : query.Where(predicate).AsQueryable();
        }

        public virtual T GetById(int id)
        {
            return Table.Find(id);
        }

        public virtual void Remove(T entity, bool isSaveLater = false)
        {
            Table.Remove(entity);
            if (!isSaveLater)
                this.Save();
        }

        public virtual int Save()
        {
             return _context.SaveChanges();
        }

        public virtual void Update(bool isSaveLater = false)
        {
            if (!isSaveLater)
                this.Save();
        }
        public virtual void Update(T entity, bool isSaveLater = false)
        {
            Table.Update(entity);
            if (!isSaveLater)
                this.Save();
        }
    }
}
