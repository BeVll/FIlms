using FIlms.Models;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using System.Collections.Generic;

namespace FIlms.Datebase
{
    public class DBContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Session> Sessions { get; set; }

        public DBContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=cinema;user=root;password=");
        }
    }
}
