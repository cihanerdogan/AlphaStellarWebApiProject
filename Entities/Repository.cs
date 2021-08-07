using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class Repository
    {
        public static List<Car> Cars = new List<Car>
        {
            new Car{Id=Guid.NewGuid(),Color="black",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            },
             new Car{Id=Guid.NewGuid(),Color="white",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            },
              new Car{Id=Guid.NewGuid(),Color="red",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            },
              new Car{Id=Guid.NewGuid(),Color="black",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            },
               new Car{Id=Guid.NewGuid(),Color="blue",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            },
                new Car{Id=Guid.NewGuid(),Color="blue",Headlights=false,Wheels=new List<Wheel>
            {
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-5)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-4)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-6)},
                new Wheel{Id=Guid.NewGuid(),ProductionDate=DateTime.Now.AddMonths(-3)},
            }
            }
        };
        public static List<Bus> Buses = new List<Bus>
            {
                new Bus{Id=Guid.NewGuid(),Color="black",Capacity=45},
                new Bus{Id=Guid.NewGuid(),Color="black",Capacity=50},
                new Bus{Id=Guid.NewGuid(),Color="red",Capacity=45},
                new Bus{Id=Guid.NewGuid(),Color="blue",Capacity=48},
                new Bus{Id=Guid.NewGuid(),Color="red",Capacity=25},
                new Bus{Id=Guid.NewGuid(),Color="white",Capacity=52},
            };
        public static List<Boat> Boats = new List<Boat>
            {
                new Boat{Id= Guid.NewGuid(),Color="white",Length=25},
                new Boat{Id= Guid.NewGuid(),Color="red",Length=30},
                new Boat{Id= Guid.NewGuid(),Color="blue",Length=12},
                new Boat{Id= Guid.NewGuid(),Color="black",Length=40},
                new Boat{Id= Guid.NewGuid(),Color="white",Length=60},
                new Boat{Id= Guid.NewGuid(),Color="red",Length=30},
                new Boat{Id= Guid.NewGuid(),Color="red",Length=25},
            };

       
    }
}
