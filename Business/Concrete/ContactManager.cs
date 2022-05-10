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
    public class ContactManager : IContactService
    {
        private IContactDal _contacDal;

        public ContactManager(IContactDal contacDal)
        {
            _contacDal = contacDal;
        }

        public IResult Add(Contact contact)
        {
            _contacDal.Add(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Delete(int contactId)
        {
            var contact = _contacDal.Get(x => x.ContactId == contactId);
            if (contact != null)
            {
                _contacDal.Delete(contact);
                return new SuccessResult(Messages.ContactDeleted);
            }
            return new ErrorResult("Hata Oluştu");
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            return new SuccessDataResult<Contact>(_contacDal.Get(c => c.ContactId == contactId));
        }

        public IDataResult<List<Contact>> GetList()
        {
            return new SuccessDataResult<List<Contact>>(_contacDal.GetList().ToList());
        }

        public IResult Update(Contact contact)
        {
            _contacDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }
    }
}
