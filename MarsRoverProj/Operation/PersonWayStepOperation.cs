using MarsRoverProj.Helper;
using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation
{
    public class PersonWayStepOperation
    {
        public static Response<List<char>> GetPersonWay(string personWay)
        {
            var personWayList = personWay.ToList();
            var response = Validate(personWayList);

            return response;

        }

        private static Response<List<char>> Validate(List<char> personWayList)
        {
            var orientations = OrientationOperation.GetOrientations();
            var orientationNames = orientations.Select(x => x.Name).ToList();
            var exceptList = personWayList.Except(orientationNames);

            if (exceptList.Any())
            {
                var orientationDescription = orientations.Select(x => x.Name + ":" + x.Description).ToList();
                return new Response<List<char>>() { IsSuccess = false, Message = "Lütfen sadece " + string.Join(",", orientationNames) + " kısaltmalarını kullanın. \r\n" + string.Join("\r\n", orientationDescription) };
            }

            return new Response<List<char>>() { IsSuccess = true,Value = personWayList };
        }
    }
}
