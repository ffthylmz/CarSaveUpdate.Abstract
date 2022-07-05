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

        public override void ClearTextBox(TextBox txtID, TextBox txtMarka, TextBox txtPrice)
        {
            txtMarka.Text = String.Empty;
            txtPrice.Text = String.Empty;
            txtID.Text = String.Empty;

        }

        public override void CreateCar(int id, string marka, double price)
        {
            Car c1 = new Car(id, marka, price);
            SeedData.CarList.Add(c1);
        }

        public override void DeleteCar(int id)
        {
            foreach (Car item in SeedData.CarList)
            {
                if (item.ID == id)
                {
                    SeedData.CarList.Remove(item);
                }
                else
                {
                    MessageBox.Show("Value Not Found!");
                }
            }
        }

        public override void Find(int id, TextBox txtMarka, TextBox txtPrice)  //?
        {
            foreach (Car item in SeedData.CarList)
            {
                if (item.ID == id)
                {
                    txtMarka.Text = item.Marka;
                    txtPrice.Text = item.Price.ToString();
                }
            }
        }

        public override List<Car> GetCars()
        {
            return SeedData.CarList.ToList();
        }

        public override void UpdateCar(int id, string marka, double price)
        {
            Car car = new Car(5, marka, price);

            foreach (Car item in SeedData.CarList)
            {
                if (item.ID == id)
                {

                    item.Marka = marka;
                    item.Price = price;
                }
            }

        }
    }
}
