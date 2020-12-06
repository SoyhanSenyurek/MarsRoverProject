using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Helper
{
    public class ReadHelper
    {
        public static string GetReadData()
        {
            return System.Console.ReadLine()?.ToUpper().Trim();
        }
    }
}
