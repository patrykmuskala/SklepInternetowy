using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SklepInternetowy.Migrations;
using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace SklepInternetowy.DAL
{
    class AlbumyInitializer : MigrateDatabaseToLatestVersion<AlbumyContext, Configuration>
    {
        public static void SeedAlbumyData(AlbumyContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria()
                {
                    KategoriaId = 1,
                    NazwaKategorii = "Rock",
                    NazwaPlikuIkony = "rock.png",
                    OpisKategorii = "Opis rock"
                },
                new Kategoria()
                {
                    KategoriaId = 2,
                    NazwaKategorii = "Pop",
                    NazwaPlikuIkony = "pop.png",
                    OpisKategorii = "Opis pop"
                },
                new Kategoria()
                {
                    KategoriaId = 3,
                    NazwaKategorii = "Metal",
                    NazwaPlikuIkony = "metal.png",
                    OpisKategorii = "Opis metal"
                },
                new Kategoria()
                {
                    KategoriaId = 4,
                    NazwaKategorii = "Rap",
                    NazwaPlikuIkony = "rap.png",
                    OpisKategorii = "Opis rap"
                },
                new Kategoria()
                {
                    KategoriaId = 5,
                    NazwaKategorii = "R&B",
                    NazwaPlikuIkony = "randb.png",
                    OpisKategorii = "Opis R&B"
                },
                new Kategoria()
                {
                    KategoriaId = 6,
                    NazwaKategorii = "Reggae",
                    NazwaPlikuIkony = "reggae.png",
                    OpisKategorii = "Opis reggae"
                },
                new Kategoria()
                {
                    KategoriaId = 7,
                    NazwaKategorii = "House",
                    NazwaPlikuIkony = "house.png",
                    OpisKategorii = "Opis house"
                }
            };
            kategorie.ForEach(k => context.Kategorie.AddOrUpdate(k));
            context.SaveChanges();
            var albumy = new List<Album>
            {
                new Album()
                {   AlbumId=1,
                    AutorAlbumu ="Nirvana",
                    TytulAlbumu ="Bleach",
                    KategoriaId =1,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="bleach.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Bleach by Nirvana"},
                new Album()
                {   AlbumId=2,
                    AutorAlbumu ="Nirvana",
                    TytulAlbumu ="Nevermind",
                    KategoriaId =1,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="nevermind.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Nevermind by Nirvana"},
                new Album()
                {   AlbumId=3,
                    AutorAlbumu ="Nirvana",
                    TytulAlbumu ="In Utero",
                    KategoriaId =1,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="inutero.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu In Utero by Nirvana"},
                new Album()
                {   AlbumId=4,
                    AutorAlbumu ="Michal Jackson",
                    TytulAlbumu ="Thriller",
                    KategoriaId =2,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="thriller.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Thriller by Michael Jackson"},
                new Album()
                {   AlbumId=5,
                    AutorAlbumu ="Michal Jackson",
                    TytulAlbumu ="Bad",
                    KategoriaId =2,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="bad.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Bad by Michael Jackson"},
                new Album()
                {   AlbumId=6,
                    AutorAlbumu ="Michal Jackson",
                    TytulAlbumu ="Dangerous",
                    KategoriaId =2,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="dangerous.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Dangerous by Michael Jackson"},
                new Album()
                {   AlbumId=7,
                    AutorAlbumu ="Korn",
                    TytulAlbumu ="Issues",
                    KategoriaId =3,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="issues.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Issues by Korn"},
                new Album()
                {   AlbumId=8,
                    AutorAlbumu ="Korn",
                    TytulAlbumu ="Untouchables",
                    KategoriaId =3,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="untouchables.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Untouchables by Korn"},
                new Album()
                {   AlbumId=9,
                    AutorAlbumu ="Korn",
                    TytulAlbumu ="Life Is Peachy",
                    KategoriaId =3,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="lifeispeachy.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Life Is Peachy by Korn"},
                new Album()
                {   AlbumId=10,
                    AutorAlbumu ="2Pac",
                    TytulAlbumu ="Strictly 4 My N.I.G.G.A.Z.",
                    KategoriaId =4,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="stricktly4myniggaz.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Strictly 4 My N.I.G.G.A.Z. by 2Pac"},
                new Album()
                {   AlbumId=11,
                    AutorAlbumu ="2Pac",
                    TytulAlbumu ="All Eyez on Me",
                    KategoriaId =4,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="alleyezonme.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu All Eyez on Me by 2Pac"},
                new Album()
                {   AlbumId=12,
                    AutorAlbumu ="2Pac",
                    TytulAlbumu ="Pac's Life",
                    KategoriaId =4,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="pacslife.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Pac's Life by 2Pac"},
                new Album()
                {   AlbumId=13,
                    AutorAlbumu ="Nelly Furtado",
                    TytulAlbumu ="Whoa, Nelly!",
                    KategoriaId =5,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="whoanelly.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Whoa, Nelly! by Nelly Furtado"},
                new Album()
                {   AlbumId=14,
                    AutorAlbumu ="Nelly Furtado",
                    TytulAlbumu ="Folklore",
                    KategoriaId =5,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="folklore.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Folklore by Nelly Furtado"},
                new Album()
                {   AlbumId=15,
                    AutorAlbumu ="Nelly Furtado",
                    TytulAlbumu ="Loose",
                    KategoriaId =5,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="loose.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Loose by Nelly Furtado"},
                new Album()
                {   AlbumId=16,
                    AutorAlbumu ="Bob Marley",
                    TytulAlbumu ="Soul Rebels",
                    KategoriaId =6,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="soulrebels.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Soul Rebels by Bob Marley"},
                new Album()
                {   AlbumId=17,
                    AutorAlbumu ="Bob Marley",
                    TytulAlbumu ="Soul Revolution",
                    KategoriaId =6,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="soulrevolution.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Soul Revolution by Bob Marley"},
                new Album()
                {   AlbumId=18,
                    AutorAlbumu ="Bob Marley",
                    TytulAlbumu ="Exodus",
                    KategoriaId =6,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="exodus.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Exodus by Bob Marley"},
                new Album()
                {   AlbumId=19,
                    AutorAlbumu ="Daft Punk",
                    TytulAlbumu ="Homework",
                    KategoriaId =7,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="homework.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Homework by Daft Punk"},
                new Album()
                {   AlbumId=20,
                    AutorAlbumu ="Daft Punk",
                    TytulAlbumu ="Discovery",
                    KategoriaId =7,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="discovery.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Discovery by Daft Punk"},
                new Album()
                {   AlbumId=21,
                    AutorAlbumu ="Daft Punk",
                    TytulAlbumu ="Human After All",
                    KategoriaId =7,
                    CenaAlbumu =100,
                    Bestseller =true,
                    NazwaPlikuObrazka ="humanafterall.png",
                    DataDodania = DateTime.Now,
                    OpisAlbumu ="Opis albumu Human After All by Daft Punk"},

};
            albumy.ForEach(k => context.Albumy.AddOrUpdate(k));
            context.SaveChanges();
        }
        public static void SeedUzytkownicy(AlbumyContext db)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            const string name = "admin@praktycznekursy.pl";
            const string password = "P@ssw0rd";
            const string roleName = "Admin";

            var user = userManager.FindByName(name);
            if (user == null)
            {
                user = new ApplicationUser { UserName = name, Email = name, DaneUzytkownika = new DaneUzytkownika() };
                var result = userManager.Create(user, password);
            }

            // utworzenie roli Admin jeśli nie istnieje 
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new IdentityRole(roleName);
                var roleresult = roleManager.Create(role);
            }
            var x = user.Id;
            //dodanie uzytkownika do roli Admin jesli juz nie jest w roli
            var rolesForUser = userManager.GetRoles(x);
            if (!rolesForUser.Contains(role.Name))
            {
                var result = userManager.AddToRole(user.Id, role.Name);
            }
        }
    }
}