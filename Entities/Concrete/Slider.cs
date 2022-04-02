using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Slider: IEntity
    {
        public int SliderId { get; set; }
        public string SliderPicture { get; set; }
    }
}
