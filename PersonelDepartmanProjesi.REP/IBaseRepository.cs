using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonelDepartmanProjesi.REP
{
    public interface IBaseRepository<T> where T : class, new()
    {
        Microsoft.EntityFrameworkCore.DbSet<T> Set();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        Task<bool> Comit();
        Task<T> Find(int id);
        Task<List<T>> ListAll();
        IQueryable<T> Qlist();
    }
}
