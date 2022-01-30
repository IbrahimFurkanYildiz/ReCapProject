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
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} ", car.Id, car.BrandName, car.ColorName, car.DailyPrice, car.Description, car.ModelYear);
            }
        }

        public static void Test()
        {

            //ColorManager colorManager = new ColorManager(new InMemoryColorDal());
            ////colorManager.Add(new Color { Id = 4, ColorName = "Lacivert" });
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //EfColorDal efColorDal = new EfColorDal();
            ////efColorDal.Add(new Colors { ColorName = "Siyah" });
            ////ColorManager colorManager = new ColorManager(new EfColorDal());


            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorName);
            //}


            //EfBrandDal efBrandDal = new EfBrandDal();
            //Console.WriteLine("Marka Giriniz (Min 2 Karakter): ");
            //BrandManager brandManager = new BrandManager(efBrandDal);
            //brandManager.Add(new Brand { BrandName = Console.ReadLine() });


            //foreach (var brands in brandManager.GetAll())
            //{
            //    Console.WriteLine(brands.BrandName);
            //}

            //EfCarDal efCarDal = new EfCarDal();
            //Console.WriteLine("Araç fiyat bilgisi giriniz (Girilen değer 0'dan büyük olmalıdır!) : ");
            ////CarManager carManager = new CarManager(efCarDal);
            //carManager.Add(new Car { BrandId = Convert.ToInt32(Console.ReadLine()), ColorId = Convert.ToInt32(Console.ReadLine()), DailyPrice = Convert.ToInt32(Console.ReadLine()), ModelYear = Convert.ToInt32(Console.ReadLine()), Description = "" });

        }
    }
}
