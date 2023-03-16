using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id + " " +car.Description);
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Id=3 Gönderilmiştir.");


            foreach (var car in carManager.GetById(3))
            {
                Console.WriteLine(car.Id + " " + car.Description);
            }


        }
    }
}