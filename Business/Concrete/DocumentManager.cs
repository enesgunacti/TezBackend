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
    public class DocumentManager:IDocumentService
    {
        private IDocumentDal _documentDal;

        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        public IResult Add(Document document)
        {
            _documentDal.Add(document);
            return new SuccessResult(Messages.DocumentAdded);
        }


        public IResult Delete(int documentId)
        {
            var document = _documentDal.Get(x => x.DocumentId == documentId);
            if (document != null)
            {
                _documentDal.Delete(document);
                return new SuccessResult(Messages.DocumentDeleted);
            }
            return new ErrorResult("Hata Oluştu");
        }

        public IDataResult<Document> GetById(int documentId)
        {
            return new SuccessDataResult<Document>(_documentDal.Get(c => c.DocumentId == documentId));
        }

        public IDataResult<List<Document>> GetList()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetList().ToList());
        }

        public IResult Update(Document document)
        {
            _documentDal.Update(document);
            return new SuccessResult(Messages.DocumentUpdated);
        }
    }
}
