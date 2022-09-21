using System;
namespace MarsRoverKataService
{
	public abstract class IDirection
	{
       public abstract IDirection TurnLeft();
       public abstract IDirection TurnRight();
        public IDirection()
		{
		}
	}
}

