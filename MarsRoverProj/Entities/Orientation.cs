using MarsRoverProj.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Data
{
    public class Orientation
    {
        public int Id { get; set; }
        public char Name { get; set; }
        public string Description { get; set; }
        public DirectionOperationEnum DirectionOperation { get; set; }
    }
}
