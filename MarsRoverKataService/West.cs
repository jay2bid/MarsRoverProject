using System;
namespace MarsRoverKataService
{
    public class West : IDirection
    {
        private readonly ILandscape _landscape;

        public West(ILandscape landscape)
        {
            _landscape = landscape;
        }

        override public IDirection TurnLeft()
        {
            return new South(_landscape);
        }

        override public IDirection TurnRight()
        {
            return new North(_landscape);
        }

        public override string ToString()
        {
            return "West";
        }
    }
}

