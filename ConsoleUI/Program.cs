using Business.Concrete;
using Core.Entities.Concrete;
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
            //CarTest();
            //UserTest();
            //CustomesTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 4004,
                CustomerId = 3,
                RentDate = new DateTime(2021, 2, 13),
                ReturnDate = null
            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }

        private static void CustomesTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 2, CompanyName = "Özden Ticaret" });
            customerManager.Add(new Customer { UserId = 4, CompanyName = "Kaya Elektrik" });
            customerManager.Update(new Customer { CustomerId = 1, UserId = 1, CompanyName = "Işıker Company" });
        }

        private static void UserTest()
        {
            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User { FirstName = "Ali", LastName = "Yılmaz", Email = "aliyilmaz@gmail.com", Password = "12345" });
            //userManager.Add(new User { FirstName = "Uğur", LastName = "Çetin", Email = "ucetin@gmail.com", Password = "54321" });
            //userManager.Update(new User { UserId = 3, FirstName = "Hakan", LastName = "Kepez", Email = "hknkpz@hotmail.com", Password = "123" });
        }

        private static void CarTest()
        {
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
