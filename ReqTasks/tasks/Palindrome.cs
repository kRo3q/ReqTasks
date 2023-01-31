namespace ReqTasks.tasks;

public static class Palindrome
{
    public static string IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentNullException(nameof(input));
        }
        var inputAsCharArr = NormalizeInputString(input).ToCharArray();
        var j = inputAsCharArr.Length - 1;
        for (var i = 0; i < j; i++)
        {
            if (inputAsCharArr[i] != inputAsCharArr[j])
            {
                return "NO";
            }
            j--;
        }
        return "YES";
    }
    private static string NormalizeInputString(string input)
    {
        return input.Replace(@"[^a-z]+gi", "").ToLower();
    }
}
