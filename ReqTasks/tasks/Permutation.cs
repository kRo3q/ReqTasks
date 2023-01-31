namespace ReqTasks.tasks;

public static class Permutation
{
    public static string ArePermutable(int[] firstArr, int[] secondArr)
    {
        if (firstArr.Length != 11 || secondArr.Length != 11)
        {
            throw new ArgumentException("Both arrays must be the size of 11");
        }

        return firstArr.Any(x => !secondArr.Contains(x)) ? "NO" : "YES";
    }
}
