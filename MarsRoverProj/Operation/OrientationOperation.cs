using MarsRoverProj.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation
{
    //static List<char> orientations = new List<char>() { 'L', 'R', 'M' };
    public class OrientationOperation
    {
        public static List<Orientation> GetOrientations()
        {
            return new List<Orientation>()
            {
                new Orientation(){Id =1, Name = 'L',DirectionOperation = Enum.DirectionOperationEnum.Left,Description = "Sola gitmesinizi sağlar"},
                new Orientation(){Id=2,Name='R',DirectionOperation = Enum.DirectionOperationEnum.Right,Description = "Sağa gitmenizi sağlar"},
                new Orientation(){Id=3,Name='M',DirectionOperation = Enum.DirectionOperationEnum.Move,Description = "1 adım ileri gitmenizi sağlar"},
            };
        }
    }
}
