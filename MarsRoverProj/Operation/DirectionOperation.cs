using MarsRoverProj.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation
{
    public class DirectionOperation
    {
        public static List<Direction> GetDirections()
        {
            var directions = new List<Direction>(){
                new Direction(){Id = 1,Name = "N",Order=1,Description="Kuzey"},
                new Direction(){Id = 2,Name="E",Order=2,Description="Doğu"},
                new Direction(){Id = 3,Name="S",Order=3,Description="Güney"},
                new Direction(){Id = 4,Name = "W",Order=4,Description="Batı"},
            };

            return directions.OrderBy(x => x.Order).ToList();
        }
    }
}
