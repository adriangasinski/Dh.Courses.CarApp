using System.Collections.Generic;
using System.Linq;

namespace Dh.Courses.CarApp.Models
{
    public class MockCarRepository : ICarRepository
    {
        private List<Car> cars;
        public MockCarRepository()
        {
            if(cars == null)
            {
                LoadCars();
            }
        }

        private void LoadCars()
        {
            cars = new List<Car>
            {
                new Car {id=1, Company="Ford", Model="Mustang", ProductionYear=2016, Mileage=106000, Capacity=4900, FuelType="gas", Description="Short and simple description", ImageURL="images/fordmustang.jpg", Power = 200, Price = 160000, IsCarOfTheWeek=true, ThumbnailURL="images/fordmustang.jpg"},
                new Car {id=2, Company="Audi", Model="A4", ProductionYear=2016, Mileage=106000, Capacity=4900, FuelType="gas", Description="Short and simple description", ImageURL="images/fordmustang.jpg", Power = 200, Price = 160000, IsCarOfTheWeek=true, ThumbnailURL="images/fordmustang.jpg"},
                new Car {id=3, Company="Audi", Model="Q5", ProductionYear=2016, Mileage=106000, Capacity=4900, FuelType="gas", Description="Short and simple description", ImageURL="images/fordmustang.jpg", Power = 200, Price = 160000, IsCarOfTheWeek=true, ThumbnailURL="images/fordmustang.jpg"},
                new Car {id=4, Company="Opel", Model="Insignia", ProductionYear=2016, Mileage=106000, Capacity=4900, FuelType="gas", Description="Short and simple description", ImageURL="images/fordmustang.jpg", Power = 200, Price = 160000, IsCarOfTheWeek=true, ThumbnailURL="images/fordmustang.jpg"},
                new Car {id=5, Company="Ford", Model="Mustang", ProductionYear=2016, Mileage=106000, Capacity=4900, FuelType="gas", Description="Short and simple description", ImageURL="images/fordmustang.jpg", Power = 200, Price = 160000, IsCarOfTheWeek=true, ThumbnailURL="images/fordmustang.jpg"}

            };
        }

        public IEnumerable<Car> GetAllCars()
        {
            return cars;
        }

        public Car GetCar(int carID)
        {
            return cars.FirstOrDefault(s => s.id == carID);
        }
    }
}
