
namespace ReqTasksTests.intersysTests;

public class ReverseArrayTests
{
    [Test]
    public void ReverseArrayTest()
    {
        var input = new [] {1,2,3};
        Assert.That(ReverseArray.GetInvertedArray(3, input), Is.EqualTo("3 2 1"));
    }

    [Test]
    public void ReverseArrayOutOfBoundSizeTest()
    {
        var input = new [] {1,2,3};
        Assert.Throws<ArgumentException>(() => ReverseArray.GetInvertedArray(5, input));
        
    }

    [Test]
    public void ReverseArrayArgumentException()
    {
        var input = new [] {1,2};
        Assert.Throws<ArgumentOutOfRangeException>(() => ReverseArray.GetInvertedArray(0, input));
    }
}
