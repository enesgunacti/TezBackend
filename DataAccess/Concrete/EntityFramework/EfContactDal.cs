using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfContactDal:EfEntityRepositoryBase<Contact,TezContext>,IContactDal
    {
    }
}
