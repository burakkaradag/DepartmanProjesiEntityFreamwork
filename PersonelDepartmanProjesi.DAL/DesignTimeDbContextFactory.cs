using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonelDepartmanProjesi.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PersonelContext>
    {
        public PersonelContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PersonelContext>();
            var connectionString = "DESKTOP-774PRMD\\SQLEXPRESS;Database=ETicaretDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new PersonelContext(builder.Options);
        }
    }
}
