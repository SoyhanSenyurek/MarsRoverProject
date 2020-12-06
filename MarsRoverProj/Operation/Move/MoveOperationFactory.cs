using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation.Move
{
    public class MoveOperationFactory
    {
        public static MoveOperationBase GetEngine(string item)
        {
            var direction = DirectionOperation.GetDirections().FirstOrDefault(x => x.Name == item);

            if (direction == null)
                throw new Exception("Engine tanımı yapılmamıştır");

            switch (direction.Name)
            {
                case "N":
                    return new MoveOperationNorth(item);
                case "W":
                    return new MoveOperationWest(item);
                case "S":
                    return new MoveOperationSouth(item);
                case "E":
                    return new MoveOperationEast(item);
                default:
                    throw new Exception("Direction Operation not found");
            }


        }
    }
}
