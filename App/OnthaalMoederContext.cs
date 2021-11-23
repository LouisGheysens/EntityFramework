using App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
    public class OnthaalMoederContext: DbContext {
        public DbSet<Kind> Kinderen { get; set; }

        public DbSet<OnthaalMoeder> OnthaalMoeders { get; set; }

        public DbSet<OverheidsInstelling> OverheidsInstellingen { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder build) {
            build.UseSqlServer(@"Data Source=DESKTOP-3CJB43N\SQLEXPRESS;Initial Catalog=EFGheysensLouis;Integrated Security=True");
        }
    }
}
