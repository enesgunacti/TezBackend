using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHizmetlerService
    {
        IDataResult<List<Hizmet>> GetList();
        IDataResult<Hizmet> GetById(int hizmetId);

        IResult Add(Hizmet hizmet);
        IResult Update(Hizmet hizmet);
        IResult Delete(int hizmetId);
    }
}
