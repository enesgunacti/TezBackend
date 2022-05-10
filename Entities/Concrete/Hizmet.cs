using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hizmet:IEntity
    {
        public int HizmetId { get; set; }
        public string HizmetAdi { get; set; }
        public string HizmetResmi { get; set; }
        public string HizmetDetay { get; set; }
        public string HizmetOzet { get; set; }
    }
}
