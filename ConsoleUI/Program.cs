using Business.Concrete;
using Business.Constants;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Collections.Generic;
using System.Threading.Channels;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();

            //Console.WriteLine(result.Message);
            //foreach (var dondur in carManager.GetCarDetails().Data)
            //{
            //    Console.WriteLine("{0}-/-{1}-/-{2}-/-{3}",dondur.CarName,dondur.BrandName,dondur.ColorName,dondur.DailyPrice);
            //}

            RentalManager rental = new RentalManager(new EfRentalDal());
            var result = rental.Add(new Rental { 
                CarId = 6, CustomerId = 2, UserId = 3, 
                RentDate = new DateTime(2023, 04, 09),ReturnDate=new DateTime(2023,04,09) });

            Console.WriteLine(result.Message);


            /*BrandManager brand = new BrandManager(new EfBrandDal());
            foreach (var item in brand.GetById(2))
            {
                Console.WriteLine(item.BrandName);
            }

            foreach (var item in brand.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            //brand.Update(new Brand { BrandId = 29, BrandName = "Ödev", ModelName = "Odevv" });
            //brand.Delete(new Brand { BrandId = 30 });
            //brand.Add(new Brand { BrandName = "BuBariOlsn", ModelName = "Ödev" });*/



            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car
            //{
            //    CarId = 47, CarName="MustafaÇELİK"
            //});


            //foreach (var cars in carManager.GetAll().Data)
            //{
            //    Console.WriteLine(cars.CarId+""+cars.CarName);
            //} 
        }
    }
}