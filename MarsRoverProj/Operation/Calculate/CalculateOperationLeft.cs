using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation.Calculate
{
    public class CalculateOperationLeft : CalculateOperationBase
    {
        public CalculateOperationLeft(char item) : base(item) { }

        public override void Calculate(PersonCoordinate personCoordinate)
        {
            var directions = DirectionOperation.GetDirections();
            var index = directions.Select(x => x.Name).ToList().IndexOf(personCoordinate.Direction);
            var lastIndex = index - 1;
            if (lastIndex < 0)
                lastIndex = directions.Count() - 1;

            var nextDirection = directions.ElementAt(lastIndex);
            personCoordinate.Direction = nextDirection.Name;
        }
    }
}
