using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA300622_G2.Entities.Concrete;

namespace WFA300622_G2.Repositories.Abstract
{
    public abstract class BaseCarRepository
    {

        // CRUD İŞLMELERİNİ YAPACAĞIZ..   CRUD ==> CREATE, UPDATE, DELETE

        public abstract List<Car> GetCars();
        public abstract void CreateCar(string model, string marka, decimal price);
        public abstract void UpdateCar(int id, string model, decimal price);
        public abstract void DeleteCar(int id);
        public abstract void Find(int id, TextBox txtModel, TextBox txtMarka, TextBox txtPrice);
        public abstract void ClearTextBox(TextBox txtModel, TextBox txtMarka, TextBox txtPrice);

    }
}
