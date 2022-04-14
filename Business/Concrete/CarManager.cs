using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }
            else
            {

                if (car.CarName.Length < 2)
                {
                    Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır.");
                }
                else
                {
                    Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır.");

                }

            }
        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);

        }
        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);

        }

    }

}
