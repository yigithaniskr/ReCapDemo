using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car 
            {
                BrandId=1,
                ColorId=2,
                DailyPrice=0,
                ModelYear=2016,
                Description= "Benzin, Otomatik, Coupe, Klimalı"
            });
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Araç bilgisi: {0} Model Yılı: {1} Günlük Ücret: {2}",car.Description, car.ModelYear, car.DailyPrice);
            }
        }
    }
}
