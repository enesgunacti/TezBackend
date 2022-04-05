using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            /////////////////////////////////////////////////////////////// ÜRÜNLER İÇİN 

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            /////////////////////////////////////////////////////////////// KATEGORİ İÇİN 

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            /////////////////////////////////////////////////////////////// İLETİŞİM BİLGİLERİ İÇİN

            builder.RegisterType<ContactManager>().As<IContactService>();
            builder.RegisterType<EfContactDal>().As<IContactDal>();

            /////////////////////////////////////////////////////////////// BELGE BİLGİLERİ İÇİN

            builder.RegisterType<DocumentManager>().As<IDocumentService>();
            builder.RegisterType<EfDocumentDal>().As<IDocumentDal>();

            /////////////////////////////////////////////////////////////// MENÜ BİLGİLERİ İÇİN

            builder.RegisterType<MenuManager>().As<IMenuService>();
            builder.RegisterType<EfMenuDal>().As<IMenuDal>();

            /////////////////////////////////////////////////////////////// SAYFA DETAY BİLGİLERİ İÇİN

            builder.RegisterType<PageManager>().As<IPageService>();
            builder.RegisterType<EfPageDal>().As<IPageDal>();

            /////////////////////////////////////////////////////////////// SLİDER RESİM BİLGİLERİ İÇİN

            builder.RegisterType<SliderManager>().As<ISliderService>();
            builder.RegisterType<EfSliderDal>().As<ISliderDal>();

            /////////////////////////////////////////////////////////////// KULLANICI BİLGİLERİ İÇİN

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();


        }
    }
}
