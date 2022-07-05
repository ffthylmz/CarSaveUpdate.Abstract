using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA300622_G2.Entities.Concrete;

namespace WFA300622_G2
{
    public static class SeedData
    {
        public static List<Car> CarList = new List<Car>()
        {
            new Car(1,"Kia",350000),
            new Car(2,"Mercedes",310000)

        };


    }
}
