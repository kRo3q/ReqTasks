
namespace IntersysTests.intersysTests;

public class UnitTests
{
    [Test]
    public void ReverseArrayTest()
    {
        var input = new [] {1,2,3};
        var expected = new [] { 3, 2, 1 };
        Assert.That(ReverseArray.ReverseArr(3, input), Is.EqualTo(expected));
    }

    [Test]
    public void ReverseArrayOutOfBoundSizeTest()
    {
        var input = new [] {1,2,3};
        
        Assert.Throws<ArgumentException>(() => ReverseArray.ReverseArr(5, input));
        
    }

    [Test]
    public void ReverseArrayArgumentException()
    {
        var input = new [] {1,2};
        Assert.Throws<ArgumentOutOfRangeException>(() => ReverseArray.ReverseArr(0, input));
    }
}
