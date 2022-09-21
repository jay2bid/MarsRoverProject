using System;
namespace MarsRoverKataService
{
    public class South : IDirection
    {
        private readonly ILandscape _landscape;

        public South(ILandscape landscape)
        {
            _landscape = landscape;
        }

        override public IDirection TurnLeft()
        {
            return new East(_landscape);
        }

        override public IDirection TurnRight()
        {
            return new West(_landscape);
        }

        public override string ToString()
        {
            return "South";
        }
    }
}

