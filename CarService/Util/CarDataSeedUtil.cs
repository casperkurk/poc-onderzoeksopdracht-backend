using System.Collections.Generic;
using CarService.Models;

namespace CarService.Util
{
    public class CarDataSeedUtil
    {
        public static List<Car> GetMotorcycles()
        {
            return new List<Car>()
            {
                new Car { Id = 1, Name = "Opel Corsa", Description = "1999, 40 kW 54 PK, Diesel", Price = 15500M, PictureId = "opel_corsa"},
                new Car { Id = 2, Name = "Citroën C3", Description = "2011, 68 kW 92 PK, Diesel", Price = 12500M, PictureId = "citroen_c3"},
                new Car { Id = 3, Name = "Audi R8", Description = "2013, 386 kW 525 PK, Benzine", Price = 33500M, PictureId = "audi_r8"},
                new Car { Id = 4, Name = "Aston Martin V8", Description = "2007, 283 kW 385 PK, Benzine", Price = 35000M, PictureId = "aston_martin_v8"}
            };
        }
    }
}