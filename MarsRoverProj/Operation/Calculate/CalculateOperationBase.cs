using MarsRoverProj.Entities;
using MarsRoverProj.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProj.Operation.Calculate
{
    public abstract class CalculateOperationBase
    {
        protected char _item;
        protected CalculateOperationBase(char item)
        {
            _item = item;
        }

        public abstract void Calculate(PersonCoordinate coordinate);

        public virtual Response<bool> PlanetSizeControl(PersonCoordinate coordinate,PlanetSize planetSize)
        {
            if (coordinate.X > planetSize.HighestX || coordinate.Y > planetSize.HighestY)
                return new Response<bool>() { IsSuccess = false,Message = "Alanın dışına çıktınız lütfen yürüme yolunu kontrol ediniz" };
            return new Response<bool>() { IsSuccess = true };
        }
    }
}
