using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static PersonelDepartmanProjesi.ENT.PersonelEntities;

namespace PersonelDepartmanProjesi.DAL
{
    public class PersonelContext : DbContext
    {
        public PersonelContext(DbContextOptions<PersonelContext> option) : base(option)
        {
        }

        DbSet<Personel> Personel { get; set; }
        DbSet<Bolum> Bolum { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-774PRMD\\SQLEXPRESS;Database=PersonelDepartmanDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }

}

