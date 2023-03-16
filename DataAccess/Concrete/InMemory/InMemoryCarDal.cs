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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=1200,ModelYear=2023,Description="Fiat Egea"},
                new Car {Id=2,BrandId=2,ColorId=2,DailyPrice=1300,ModelYear=2023,Description="Renault Clio"},
                new Car {Id=3,BrandId=3,ColorId=2,DailyPrice=1100,ModelYear=2022,Description="Citroen C Elysee"},
                new Car {Id=4,BrandId=4,ColorId=1,DailyPrice=712,ModelYear=2023,Description="Dacia Logan"},
                new Car {Id=5,BrandId=5,ColorId=1,DailyPrice=1280,ModelYear=2022,Description="Ford Tourneo Courier"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

     
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(car => car.Id == car.Id);
            
            carUpdate.Id = car.Id;
            carUpdate.BrandId=car.BrandId;
            carUpdate.ColorId=car.ColorId;
            carUpdate.ModelYear=car.ModelYear;
            carUpdate.Description=car.Description;


        }
    }
}
