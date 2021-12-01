﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carService = new CarManager(new EfCarDal());
            //carService.Add(new Car {BrandId = 3, ColorId = 2, CarName = "Toyota", DailyPrice = 3500, ModelYear = 2016, Description = "Aile Aracı" });

            foreach (var car in carService.GetCarDetails())
            {
                Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
            }

        }
    }
}
