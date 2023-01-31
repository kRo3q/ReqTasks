namespace ReqTasksTests.intersysTests;

public class PalindromeTests
{
    [Test]
    public void PalindromeTest()
    {
        Assert.That(Palindrome.IsPalindrome("abut-1-tuba"), Is.EqualTo("YES"));
        Assert.That(Palindrome.IsPalindrome("@allula"), Is.EqualTo("NO"));
    }

    [Test]
    public void PalindromeArgumentNullExceptionTest()
    {
        Assert.Throws<ArgumentNullException>(() => Palindrome.IsPalindrome(""));
    }
}
