using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleUI // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CarManager carManager =new CarManager(new InMemoryCarDal());
            foreach(var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}