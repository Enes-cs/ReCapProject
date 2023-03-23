using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Color Id=4 olan araçların Id listesi");
            Console.WriteLine("-----------------------------------");

            carManager.Add(new Car { CarName="A",DailyPrice=0});
            

            foreach (var car in carManager.GetCarsByColorId(4))
            {
                Console.WriteLine(car.Id);
            }
            Console.WriteLine("-----------------------------------");

        }
    }
}