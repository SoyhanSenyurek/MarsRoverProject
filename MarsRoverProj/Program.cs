using MarsRoverProj.Entities;
using MarsRoverProj.Enum;
using MarsRoverProj.Helper;
using MarsRoverProj.Model;
using MarsRoverProj.Operation;
using MarsRoverProj.Operation.Calculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MarsRoverProj
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Operation();
        }

        private static void Operation()
        {
            var planetSize = StepOne();
            StepOperation(planetSize);
            
        }

        private static void FinishOperation(PlanetSize planetSize)
        {
            Console.WriteLine("'0' gezegen boyutlarını girmenizi sağlar, '1' yeni bir kullanıcı girmenizi sağlar");
            var operation = ReadHelper.GetReadData();
            switch (operation)
            {
                case "0":
                    Operation();
                    break;
                case "1":
                    StepOperation(planetSize);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }

        }

        private static void StepOperation(PlanetSize planetSize)
        {
            var personCoordinate = StepTwo(planetSize);

            WayOperation(personCoordinate, planetSize);


            FinishOperation(planetSize);
        }

        private static void WayOperation(PersonCoordinate personCoordinate, PlanetSize planetSize)
        {
            var personWayList = StepThree();

            var personCoordinateClone = personCoordinate.DeepClone();
            foreach (var item in personWayList)
            {
                var engine = CalculateOperationFactory.GetEngine(item);
                engine.Calculate(personCoordinate);
                var response = engine.PlanetSizeControl(personCoordinate, planetSize);

                if (!response.IsSuccess)
                {
                    Console.WriteLine(response.Message);
                    WayOperation(personCoordinateClone, planetSize);
                    return;
                }
            }

            Console.WriteLine("Son Konum :(" + personCoordinate.X + "," + personCoordinate.Y + ") -> " + personCoordinate.Direction);
        }

        private static List<char> StepThree()
        {
            Console.WriteLine("Lütfen gezegendeki kişinin gitmek istediği yeri giriniz(Örn: LMLMLRLMM) : ");
            var personWay = ReadHelper.GetReadData();

            var personWayList = PersonWayStepOperation.GetPersonWay(personWay);

            if(!personWayList.IsSuccess)
            {
                Console.WriteLine(personWayList.Message);
                personWayList.Value = StepThree();
            }
            return personWayList.Value;
        }

        private static PersonCoordinate StepTwo(PlanetSize planetSize)
        {
            Console.WriteLine("Lütfen gezegendeki kişinin koordinatını ve şuanda hangi yöne baktını giriniz(Örn: 1 2 N) : ");
            var readedData = ReadHelper.GetReadData();

            var personCoordinate = PersonCoordinateStepOperation.GetPersonCoordinate(readedData, planetSize);

            if(!personCoordinate.IsSuccess)
            {
                Console.WriteLine(personCoordinate.Message);
                personCoordinate.Value = StepTwo(planetSize);
            }

            return personCoordinate.Value;
        }

        private static PlanetSize StepOne()
        {
            Console.Write("Lütfen gezegenin boyutunu giriniz (Örn: 5 5) : ");
            var planetSize = ReadHelper.GetReadData();

            var planetCoordinate = PlanetSizeStepOperation.GetPlanetSize(planetSize);

            if (!planetCoordinate.IsSuccess)
            {
                Console.WriteLine(planetCoordinate.Message);
                planetCoordinate.Value = StepOne();
            }
            return planetCoordinate.Value;
        }
    }
}
