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

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("CarId: {0} BrandName: {1} ColorName: {2} DailyPrice: {3}", car.CarId, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }
            Console.WriteLine(colorManager.GetById(1).Data);
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            colorManager.Delete(new Color { ColorId = 1002 });
            colorManager.Update(new Color { ColorId = 2, ColorName = "Gri" });
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine(brandManager.GetById(1).Data);
            brandManager.Add(new Brand { BrandName = "Toyota" });
            brandManager.Delete(new Brand { BrandId = 1003 });
            brandManager.Update(new Brand { BrandId = 2, BrandName = "Fiat" });
            
        }
    }
}
