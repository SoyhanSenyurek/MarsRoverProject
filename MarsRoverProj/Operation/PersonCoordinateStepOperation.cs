using MarsRoverProj.Entities;
using MarsRoverProj.Enum;
using MarsRoverProj.Helper;
using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation
{
    public class PersonCoordinateStepOperation
    {
        public static Response<PersonCoordinate> GetPersonCoordinate(string personCoordinate,PlanetSize planetSize)
        {
            
            var personCoordinateList = personCoordinate.Split(' ').ToList();
            var response = Validate(personCoordinateList,planetSize);

            return response;
        }

        private static Response<PersonCoordinate> Validate(List<string> personCoordinate, PlanetSize planetSize)
        {
            if (personCoordinate.Count() != 3)
                return new Response<PersonCoordinate>() { IsSuccess = false, Message = "Lütfen 2 adet sayı ve 1 adet harf giriniz" };

            var x = personCoordinate[0].ToIntConvert();
            var y = personCoordinate[1].ToIntConvert();
            if (!x.HasValue || !y.HasValue)
                return new Response<PersonCoordinate>() { IsSuccess = false, Message = "Lütfen arasında boşluk bırakarak 2 adet sayı ve 1 adet harf giriniz" };

            if (x > planetSize.HighestX || y > planetSize.HighestY)
                return new Response<PersonCoordinate>() { IsSuccess = false, Message = "Girilen değerler en büyükleri aşmaktadır Lütfen x:" + planetSize.HighestX + " y:" + planetSize.HighestY + " arasında bir değer giriniz." };

            var direction = personCoordinate[2].ToString();

            var directionList = DirectionOperation.GetDirections();
            var directionItem = directionList.Where(x => x.Name == direction);

            if (!directionItem.Any())
                return new Response<PersonCoordinate>() { IsSuccess = false, Message = "Sadece bu işlemleri yapabilirsiniz. İşlemler :" + string.Join(",", directionList.Select(x => x.Name + ":" + x.Description)) };

            return new Response<PersonCoordinate> { IsSuccess = true, Value = new PersonCoordinate() { X = x.Value, Y = y.Value, Direction = direction } };
        }
    }
}
