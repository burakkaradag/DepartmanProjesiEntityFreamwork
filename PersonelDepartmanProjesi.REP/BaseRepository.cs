using PersonelDepartmanProjesi.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace PersonelDepartmanProjesi.REP
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        public PersonelContext db;
        public BaseRepository(PersonelContext _db)
        {
            db = _db;
        }
        public void Add(T entity)
        {
            db.Entry(entity).State = EntityState.Added;
        }
      
        public async Task<bool> Comit()
        {
            
            try
            {
                await db.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public void Delete(T entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
        }

        public virtual async Task<T> Find(int id)
        {
            return await Set().FindAsync(id);
        }


        public async Task<List<T>> ListAll()
        {
            return await Set().ToListAsync();
        }

        public IQueryable<T> Qlist()
        {
            return Set().AsQueryable();
        }

        public Microsoft.EntityFrameworkCore.DbSet<T> Set()
        {
            return db.Set<T>();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
