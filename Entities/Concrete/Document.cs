using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Document:IEntity
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
    }
}
