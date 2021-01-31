﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=350, Description="Benzinli, Manuel, Sedan, Klimalı"},
                new Car{CarId=2, BrandId=2, ColorId=1, ModelYear=2010, DailyPrice=250, Description="Dizel, Otomatik, Hatchback, Klimalı"},
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear=2017, DailyPrice=375, Description="Benzinli, Otomatik, Hatchback, Klimalı"},
                new Car{CarId=4, BrandId=3, ColorId=2, ModelYear=2012, DailyPrice=300, Description="Hybrid, Otomatik, Hatchback, Klimalı"},
                new Car{CarId=5, BrandId=1, ColorId=3, ModelYear=1999, DailyPrice=125, Description="Dizel, Manuel, Sedan, Klimasız"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
