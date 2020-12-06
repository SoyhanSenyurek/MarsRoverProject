using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Model
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
}
