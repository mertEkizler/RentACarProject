using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            //Add();
            //Delete();
            //Update();
            //GetById();
        }

        //private static void GetById()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    foreach (var item4 in carManager.GetById(3))
        //    {
        //        Console.WriteLine(item4.CarName);
        //    }
        //}

        //private static void Update()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    carManager.Update(new Car { CarName = "Doğan", BrandId = 2, CarId = 1, ColorId = 2, DailyPrice = 40, Description = "benzin", ModelYear = 1992 });
        //    foreach (var item3 in carManager.GetAll())
        //    {
        //        Console.WriteLine(item3.CarId + " " + item3.CarName + " " + item3.BrandId + " " + item3.ColorId + " " + item3.DailyPrice + " " + item3.Description + " " + item3.ModelYear);
        //    }
        //}

        //private static void Delete()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    carManager.Delete(new Car { CarId = 3 });
        //    foreach (var item2 in carManager.GetAll())
        //    {
        //        Console.WriteLine(item2.CarName);
        //    }
        //}

        //private static void Add()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    carManager.Add(new Car { CarName = "Şahin", BrandId = 2, CarId = 3, ColorId = 4, DailyPrice = 30, Description = "tüplü", ModelYear = 1993 });
        //    foreach (var item in carManager.GetAll())
        //    {
        //        Console.WriteLine(item.CarName);
        //    }
        //}

        //private static void GetAll()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    foreach (var cars in carManager.GetAll())
        //    {
        //        Console.WriteLine(cars.CarId + " " + cars.CarName + " " + cars.BrandId + " " + cars.ColorId + " " + cars.DailyPrice + " " + cars.Description + " " + cars.ModelYear);
        //    }
        //}
    }
}
