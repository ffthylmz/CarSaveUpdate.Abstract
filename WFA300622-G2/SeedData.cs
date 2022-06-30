using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA300622_G2.Entities.Concrete;

namespace WFA300622_G2
{
    public class SeedData
    {
        public List<Car> CarList = new List<Car>()
        {
            new Car(1,"Kia","Ceed",350000m),
            new Car(2,"Kia","Rio",310000m)

        };


    }
}
