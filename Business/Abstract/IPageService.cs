using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPageService
    {
        IDataResult<List<Page>> GetList();
        IResult Add(Page page);
        IResult Update(Page page);
        IResult Delete(Page page);
    }
}
