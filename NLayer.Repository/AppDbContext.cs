using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository
{
    public class AppDbContext : DbContext
    {
        // "startup.cs" dosyasından veri tabanı yolunu kolay bir şekilde verebilmek için, mutlaka "DbContextOptions" alan bir "constructor" oluşturulmalıdır.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Her bir entity'e karşılık gelen DbSet'ler oluşturulur.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurations klasörünün içerisinde yapılan tüm işlemlerden EF Core'un haberinin olması için kullanılan metot.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
