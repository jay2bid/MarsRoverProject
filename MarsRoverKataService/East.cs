using System;
namespace MarsRoverKataService
{
    public class East : IDirection
    {
        private readonly ILandscape _landscape;

        public East(ILandscape landscape)
        {
            _landscape = landscape;
        }

        override public IDirection TurnLeft()
        {
            return new North(_landscape);
        }

        override  public IDirection TurnRight()
        {
            return new South(_landscape);
        }

        public override string ToString()
        {
            return "East";
        }
    }

}

