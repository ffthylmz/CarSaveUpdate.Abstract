using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA300622_G2.Entities.Abstract;

namespace WFA300622_G2.Entities.Concrete
{
    public class Car : BaseEntity
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(int id, string marka, string model, decimal price)
        {
            ID = id;
            Marka = marka;
            Model = model;
            Price = price;
        }


    }
}
