using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace melo.Model
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EHVPQGR;Initial Catalog=wpf_proje;Integrated Security=True;Pooling=False");
        }

        public DbSet<author>authors { get; set; }
        public DbSet<book>books { get; set; }
        public DbSet<Publisher>publishers { get; set; }
        public DbSet<Login>logins { get; set; }
    }
}
