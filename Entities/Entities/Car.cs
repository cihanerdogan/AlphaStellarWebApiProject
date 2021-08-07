using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
  public class Car:Vehicle
    {
        public bool Headlights { get; set; }
        public List<Wheel> Wheels { get; set; }
    }
}
