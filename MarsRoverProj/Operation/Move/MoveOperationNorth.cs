using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation.Move
{
    public class MoveOperationNorth : MoveOperationBase
    {
        public MoveOperationNorth(string item) : base(item) { }
        public override void Operation(PersonCoordinate personCoordinate)
        {
            personCoordinate.Y++;
        }
    }
}
