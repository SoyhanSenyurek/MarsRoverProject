using MarsRoverProj.Entities;
using MarsRoverProj.Helper;
using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation
{
    public class PlanetSizeStepOperation
    {
        public static Response<PlanetSize> GetPlanetSize(string planetSize)
        {
            var planetCoordinate = planetSize.Split(' ').ToList();
            var response = Validate(planetCoordinate);
            

            return response;
        }

        private static Response<PlanetSize> Validate(List<string> planetSize)
        {
            if (planetSize.Count() != 2)
                return new Response<PlanetSize>() { IsSuccess = false, Message = "Lütfen 2 adet sayı giriniz" };

            var highestX = planetSize[0].ToIntConvert();
            var highestY = planetSize[1].ToIntConvert();
            if (!highestX.HasValue || !highestY.HasValue)
                return new Response<PlanetSize>() { IsSuccess = false, Message = "Lütfen arasında boşluk bırakarak 2 adet sayı giriniz" };

            return new Response<PlanetSize> { IsSuccess = true, Value = new PlanetSize() { HighestX = highestX.Value, HighestY = highestY.Value } };
        }
    }
}
