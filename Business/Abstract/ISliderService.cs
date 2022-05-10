using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISliderService
    {
        IDataResult<List<Slider>> GetList();
        IDataResult<Slider> GetById(int sliderId);

        IResult Add(Slider slider);
        IResult Update(Slider slider);
        IResult Delete(int sliderId);

    }
}
