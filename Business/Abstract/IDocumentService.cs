using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        IDataResult<List<Document>> GetList();
        IResult Add(Document document);
        IResult Update(Document document);
        IResult Delete(int documentId);

        IDataResult<Document> GetById(int documentId);
    }
}
