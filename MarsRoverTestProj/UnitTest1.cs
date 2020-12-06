using MarsRoverProj.Entities;
using MarsRoverProj.Model;
using MarsRoverProj.Operation.Calculate;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoverTestProj
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LeftMoveExample()
        {
            PlanetSize planetSize = new PlanetSize() { HighestX=5,HighestY=5 };
            PersonCoordinate personCoordinate = new PersonCoordinate() { X =1,Y=2,Direction="N" };
            string personWay = "LMLMLMLMM";
            List<char> personWayList = personWay.ToList();
            foreach (var item in personWayList)
            {
                var engine = CalculateOperationFactory.GetEngine(item);
                engine.Calculate(personCoordinate);
            }

            Assert.AreEqual(personCoordinate.X, 1);
            Assert.AreEqual(personCoordinate.Y, 3);
            Assert.AreEqual(personCoordinate.Direction, "N");
            Assert.Pass();
        }

        [Test]
        public void RightMoveExample()
        {
            PlanetSize planetSize = new PlanetSize() { HighestX = 5, HighestY = 5 };
            PersonCoordinate personCoordinate = new PersonCoordinate() { X = 3, Y = 3, Direction = "E" };
            string personWay = "MMRMMRMRRM";
            List<char> personWayList = personWay.ToList();
            foreach (var item in personWayList)
            {
                var engine = CalculateOperationFactory.GetEngine(item);
                engine.Calculate(personCoordinate);
            }

            Assert.AreEqual(personCoordinate.X, 5);
            Assert.AreEqual(personCoordinate.Y, 1);
            Assert.AreEqual(personCoordinate.Direction, "E");
            Assert.Pass();
        }

        [Test]
        public void PlanetSizeConrolExample()
        {
            PlanetSize planetSize = new PlanetSize() { HighestX = 5, HighestY = 5 };
            PersonCoordinate personCoordinate = new PersonCoordinate() { X = 3, Y = 3, Direction = "E" };
            string personWay = "MMRMMRMRRMM";
            List<char> personWayList = personWay.ToList();
            foreach (var item in personWayList)
            {
                var engine = CalculateOperationFactory.GetEngine(item);
                engine.Calculate(personCoordinate);
                var response = engine.PlanetSizeControl(personCoordinate,planetSize);
                if (!response.IsSuccess)
                    Assert.Pass();
            }
            Assert.Fail();
        }
    }
}