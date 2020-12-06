using MarsRoverProj.Model;
using MarsRoverProj.Operation.Move;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation.Calculate
{
    public class CalculateOperationMove : CalculateOperationBase
    {
        public CalculateOperationMove(char item) : base(item) { }

        public override void Calculate(PersonCoordinate personCoordinate)
        {
            var engine = MoveOperationFactory.GetEngine(personCoordinate.Direction);
            engine.Operation(personCoordinate);
        }
    }
}
