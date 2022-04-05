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
    public class PageManager:IPageService
    {
        private IPageDal _pageDal;

        public PageManager(IPageDal pageDal)
        {
            _pageDal = pageDal;
        }

        public IResult Add(Page page)
        {
            _pageDal.Add(page);
            return new SuccessResult(Messages.PageAdded);
        }

        public IResult Delete(Page page)
        {
            _pageDal.Delete(page);
            return new SuccessResult(Messages.PageDeleted);
        }

        public IDataResult<List<Page>> GetList()
        {
            return new SuccessDataResult<List<Page>>(_pageDal.GetList().ToList());
        }

        public IResult Update(Page page)
        {
            _pageDal.Update(page);
            return new SuccessResult(Messages.PageUpdated);
        }
    }
}
