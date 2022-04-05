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
    public class SliderManager : ISliderService
    {
        private ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public IResult Add(Slider slider)
        {
            _sliderDal.Add(slider);
            return new SuccessResult(Messages.SliderAdded);
        }

        public IResult Delete(Slider slider)
        {
            _sliderDal.Delete(slider);
            return new SuccessResult(Messages.SliderDeleted);
        }

        public IDataResult<Slider> GetById(int sliderId)
        {
            return new SuccessDataResult<Slider>(_sliderDal.Get(c => c.SliderId == sliderId));
        }

        public IDataResult<List<Slider>> GetList()
        {
            return new SuccessDataResult<List<Slider>>(_sliderDal.GetList().ToList());
        }

        public IResult Update(Slider slider)
        {
            _sliderDal.Update(slider);
            return new SuccessResult(Messages.SliderUpdated);
        }
    }
}
