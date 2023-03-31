using Business.Concrete;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Threading.Channels;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Ödev" });
            //colorManager.Delete(new Color { ColorId = 17});

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var dondur in carManager.GetCarDetails())
            {
                Console.WriteLine("{0}-/-{1}-/-{2}-/-{3}",dondur.CarName,dondur.BrandName,dondur.ColorName,dondur.DailyPrice);
            }


            /*BrandManager brand = new BrandManager(new EfBrandDal());
            foreach (var item in brand.GetById(2))
            {
                Console.WriteLine(item.BrandName);
            }

            foreach (var item in brand.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
            /*brand.Update(new Brand { BrandId = 29,BrandName="Ödev",ModelName="Odevv" });
            /*brand.Delete(new Brand { BrandId = 30 });
            /*brand.Add(new Brand { BrandName = "BuBariOlsn", ModelName = "Ödev" });



            /*CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarName = "KaydetArtık", DailyPrice = 99 });

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.CarName);
            } */
        }
    }
}