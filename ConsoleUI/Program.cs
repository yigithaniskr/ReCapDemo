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
            //BrandTest();
            //ColorTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("CarId: {0} BrandName: {1} ColorName: {2} DailyPrice: {3}", car.CarId, car.BrandName, car.ColorName, car.DailyPrice);
            }
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Toyota" });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(colorManager.GetById(1).ColorName);
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            colorManager.Delete(new Color { ColorId = 1002 });
            colorManager.Update(new Color { ColorId = 2, ColorName = "Gri" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetById(1).BrandName);
            brandManager.Add(new Brand { BrandName = "Toyota" });
            brandManager.Delete(new Brand { BrandId = 1003 });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Fiat" });
        }
    }
}
