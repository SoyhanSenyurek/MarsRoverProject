using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation.Move
{
    public class MoveOperationWest:  MoveOperationBase
    {
        public MoveOperationWest(string item) : base(item) { }

        public override void Operation(PersonCoordinate personCoordinate)
        {
            personCoordinate.X--;
        }
    }
}
