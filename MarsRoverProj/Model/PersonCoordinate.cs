using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Model
{
    [Serializable]
    public class PersonCoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
    }
}
