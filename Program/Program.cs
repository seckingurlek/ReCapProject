using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Colorize();
           //CarManager carManager =new CarManager(new EfCarDal());
           // foreach (var car in carManager.GetCarsByBrandId(2))
           // {
           //     Console.WriteLine(car.Description);
           // }
           
        }

        //private static void Colorize()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}
    }
}