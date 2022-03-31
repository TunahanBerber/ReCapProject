using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1 , ColorId = 1, DailyPrice = 490000, Description = "Kırmızı Mercedes A180 CDI BlueEffiency Urban", ModelYear = 2014},
                new Car{CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 490000, Description = "Beyaz Mercedes A180 CDI BlueEffiency Urban", ModelYear = 2014},
                new Car{CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 552000, Description = "Füme Seat Leon 1.5 TSI FR", ModelYear = 2021},
                new Car{CarId = 4, BrandId = 3, ColorId = 4, DailyPrice = 1565000, Description = "Siyah BMW 4 Serisi 420i Editiın M Sport", ModelYear = 22020},
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
