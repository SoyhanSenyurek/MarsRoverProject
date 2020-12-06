using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRoverProj.Operation.Calculate
{
    public class CalculateOperationFactory
    {
        public static CalculateOperationBase GetEngine(char item)
        {
            var direction = OrientationOperation.GetOrientations().FirstOrDefault(x => x.Name == item);

            if (direction == null)
                throw new Exception("Engine tanımı yapılmamıştır");

            switch (direction.DirectionOperation)
            {
                case Enum.DirectionOperationEnum.Left:
                    return new CalculateOperationLeft(item);
                case Enum.DirectionOperationEnum.Right:
                    return new CalculateOperationRight(item);
                case Enum.DirectionOperationEnum.Move:
                    return new CalculateOperationMove(item);
                default:
                    throw new Exception("Direction Operation not found");
            }

            
        }
    }
}
