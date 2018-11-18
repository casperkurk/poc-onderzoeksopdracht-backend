using System.Collections.Generic;
using MotorcycleService.Models;

namespace MotorcycleService.Util
{
    public class MotorcycleDataSeedUtil
    {
        public static List<Motorcycle> GetMotorcycles()
        {
            return new List<Motorcycle>()
            {
                new Motorcycle { Id = 1, Name = "Honda CBR 600", Description = "2004, 88 kW/120 PK, Benzine", Price = 15500M, PictureId = "honda_cbr_600"},
                new Motorcycle { Id = 2, Name = "Kawasaki ZZR 600", Description = "1994, 74 kW/101 PK, Benzine", Price = 12500M, PictureId = "kawasaki_zzr_600"},
                new Motorcycle { Id = 3, Name = "Yamaha YZF 600", Description = "2003, 74 kW/101 PK, Benzine", Price = 20500M, PictureId = "yamaha_yzf_600"},
                new Motorcycle { Id = 4, Name = "Ducati 750 SS", Description = "2000, 48 kW/65 PK, Benzine", Price = 18000M, PictureId = "ducati_750_ss"}
            };
        }
    }
}