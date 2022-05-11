using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class TezContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I3FVNCJ;Database=TezBackend;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; } /// ÜRÜNLER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Category> Categories { get; set; } /// KATEGORİLER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Contact> Contacts { get; set; } /// İLETİŞİM BİLGİLERİ VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Document> Documents { get; set; } /// BELGELER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Menu> Menus { get; set; } /// MENÜLER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Page> Pages { get; set; } /// SAYFA İÇERİKLERİ VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Slider> Sliders { get; set; } /// SLİDER RESİMLER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<User> Users { get; set; } /// KULLANICI VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<Hizmet> Hizmetler { get; set; } /// HİZMETLER VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<OperationClaim> OperationClaims { get; set; } /// KULLANICI VERİ TABANI BAĞLANTISI İÇİN
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; } /// KULLANICI VERİ TABANI BAĞLANTISI İÇİN

        

    }
}
