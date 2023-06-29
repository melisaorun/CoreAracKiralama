using CoreAracKiralama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAracKiralama.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public virtual DbSet<Islemler> Islemler { get; set; }
        public virtual DbSet<Araclar> Araclar { get; set;}
        public virtual DbSet<Kampanyalar> Kampanyalar { get; set;}
    }
}
