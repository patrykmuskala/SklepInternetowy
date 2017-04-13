using Microsoft.AspNet.Identity.EntityFramework;
using SklepInternetowy.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SklepInternetowy.DAL
{
    public class AlbumyContext : IdentityDbContext<ApplicationUser>
    {
        public AlbumyContext() : base("AlbumyContext")
        {

        }
        static AlbumyContext()
        {
            Database.SetInitializer<AlbumyContext>(new AlbumyInitializer());
        }
        public DbSet<Album> Albumy { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public static AlbumyContext Create()
        {
            return new AlbumyContext();
        }
    }
}