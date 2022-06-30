using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA300622_G2.Entities.Concrete;
using WFA300622_G2.Repositories.Abstract;

namespace WFA300622_G2.Repositories.Concrete
{
    public class CarRepositories : BaseCarRepository
    {
        public override void ClearTextBox(TextBox txtModel, TextBox txtMarka, TextBox txtPrice)
        {
            throw new NotImplementedException();
        }

        public override void CreateCar(string model, string marka, decimal price)
        {
            throw new NotImplementedException();
        }

        public override void DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public override void Find(int id, TextBox txtModel, TextBox txtMarka, TextBox txtPrice)
        {
            throw new NotImplementedException();
        }

        public override List<Car> GetCars()
        {
            throw new NotImplementedException();
        }

        public override void UpdateCar(int id, string model, decimal price)
        {
            throw new NotImplementedException();
        }
    }
}
