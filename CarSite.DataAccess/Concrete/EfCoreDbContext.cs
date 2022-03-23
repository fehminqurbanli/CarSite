using CarSite.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSite.DataAccess.Concrete
{
    public class EfCoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-7HQC4KAK832;Initial Catalog=CarSiteDb1;Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>()
                .HasOne<Brand>(b => b.brand)
                .WithMany(a => a.Models)
                .HasForeignKey(b => b.BrandId);

            //GeneralType-GeneralInfo relation
            modelBuilder.Entity<GeneralInfo>()
                .HasOne<GeneralType>(b => b.GeneralType)
                .WithMany(a => a.GeneralInfo)
                .HasForeignKey(b => b.TypeId);

            //TB_ADS-TB_ADSIMAGES relation
            modelBuilder.Entity<TB_AdsImages>()
                .HasOne<TB_Ads>(b => b.TB_Ads)
                .WithMany(a => a.TB_AdsImages)
                .HasForeignKey(x => x.Ads_Id);
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<GeneralType> GeneralTypes { get; set; }
        public DbSet<GeneralInfo> GeneralInfos { get; set; }
        public DbSet<TB_Ads> TB_Ads { get; set; }
        public DbSet<TB_AdsImages> TB_AdsImages { get; set; }



    }
}
