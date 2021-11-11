using Day2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    public class PeopelContext : DbContext
    {
        public DbSet<Person> Peopel { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=peopeldb");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"DataSource=C:\Users\Virtualpro\Documents\NET6\Hi World\Day2\WpfApp1\peopeldb.db");
        }
    }
}
