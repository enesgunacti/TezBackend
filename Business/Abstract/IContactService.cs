﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetList();
        IResult Add(Contact contact);
        IResult Update(Contact contact);
        IResult Delete(Contact contact);
    }
}
