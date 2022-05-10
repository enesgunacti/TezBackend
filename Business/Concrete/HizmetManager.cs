using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HizmetManager : IHizmetlerService
    {
        private IHizmetDal _hizmetDal;

        public HizmetManager(IHizmetDal hizmetDal)
        {
            _hizmetDal = hizmetDal;
        }

        public IResult Add(Hizmet hizmet)
        {
            _hizmetDal.Add(hizmet);
            return new SuccessResult(Messages.HizmetAdded);
        }

        public IResult Delete(int hizmetId)
        {
            var hizmet = _hizmetDal.Get(x => x.HizmetId == hizmetId);
            if (hizmet != null)
            {
                _hizmetDal.Delete(hizmet);
                return new SuccessResult(Messages.HizmetDeleted);
            }
            return new ErrorResult("Hata Oluştu");
        }

        public IDataResult<Hizmet> GetById(int hizmetId)
        {
            return new SuccessDataResult<Hizmet>(_hizmetDal.Get(c => c.HizmetId == hizmetId));
        }

        public IDataResult<List<Hizmet>> GetList()
        {
            return new SuccessDataResult<List<Hizmet>>(_hizmetDal.GetList().ToList());
        }

        public IResult Update(Hizmet hizmet)
        {
            _hizmetDal.Update(hizmet);
            return new SuccessResult(Messages.HizmetUpdated);
        }
    }
}
