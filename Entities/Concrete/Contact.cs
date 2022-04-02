using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Contact:IEntity
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactDetail { get; set; }
    }
}
