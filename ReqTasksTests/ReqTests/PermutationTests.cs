namespace ReqTasksTests.intersysTests;

public class PermutationTests
{
    [Test]
    public void PermutationTest()
    {
        var firstArr = new[] { 7, 3, 1, 2, 5, 0, 5, 2, 1, 3, 7 };
        var secondArr = new[] { 1, 2, 5, 3, 7, 0, 7, 3, 5, 2, 1};
        Assert.That(Permutation.ArePermutable(firstArr, secondArr), Is.EqualTo("YES"));

        var thirdArr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        var fourthArr = new[] { 6, 5, 4, 3, 2, 0, 11, 10, 9, 8, 7 };
        Assert.That(Permutation.ArePermutable(thirdArr, fourthArr), Is.EqualTo("NO"));
    }
}
