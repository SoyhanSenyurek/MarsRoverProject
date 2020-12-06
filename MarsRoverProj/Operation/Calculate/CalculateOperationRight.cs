using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation.Calculate
{
    public class CalculateOperationRight : CalculateOperationBase
    {
        public CalculateOperationRight(char item) : base(item) { }

        public override void Calculate(PersonCoordinate personCoordinate)
        {
            var directions = DirectionOperation.GetDirections();
            var index = directions.Select(x => x.Name).ToList().IndexOf(personCoordinate.Direction);
            var nextIndex = index + 1;
            if (nextIndex >= directions.Count())
                nextIndex = 0;

            var nextDirection = directions.ElementAt(nextIndex);
            personCoordinate.Direction = nextDirection.Name;
        }
    }
}
