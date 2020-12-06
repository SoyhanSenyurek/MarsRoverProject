using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation.Move
{
    public abstract class MoveOperationBase
    {
        protected string _item;
        protected MoveOperationBase(string item)
        {
            _item = item;
        }

        public abstract void Operation(PersonCoordinate coordinate);
    }
}
