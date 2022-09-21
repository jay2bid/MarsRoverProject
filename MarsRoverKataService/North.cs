using System;
namespace MarsRoverKataService
{
	public class North : IDirection
	{

        private readonly ILandscape _landscape;
        public North(ILandscape landscape)
        {
            _landscape = landscape;
        }

        override public  IDirection TurnLeft()
        {
            return new West(_landscape);
        }

        override public IDirection TurnRight()
        {
            return new East(_landscape);
        }

        public override string ToString()
        {
            return "North";
        }





    }
}

