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
        public DbSet<Product> Products { get; set; } /// ÜRÜNLER VERİ TABANI BAĞLANTI İÇİN
        public DbSet<Category> Categories { get; set; } /// KATEGORİLER VERİ TABANI BAĞLANTI İÇİN
        public DbSet<Contact> Contacts { get; set; } /// İLETİŞİM BİLGİLERİ VERİ TABANI BAĞLANTI İÇİN

    }
}
