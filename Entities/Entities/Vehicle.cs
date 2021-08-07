using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public string Color { get; set; }
    }
}
