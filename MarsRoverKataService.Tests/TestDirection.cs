using NUnit.Framework.Internal;

namespace MarsRoverKataService.Tests;

public class TestDirection
{
    ILandscape _landscape;

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void When_Rover_North_And_Turn_Left_Command_Direction_Should_Be_West()
    {
        var direction = new North(_landscape);
        var newdirection = direction.TurnLeft();
        Assert.That(newdirection, Is.TypeOf(typeof(West)));
    }
}  