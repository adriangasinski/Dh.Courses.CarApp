using System.Collections.Generic;

namespace Dh.Courses.CarApp.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCar(int carID);
    }
}
