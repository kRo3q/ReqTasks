namespace ReqTasks.tasks;

using System;
using System.Linq;

public static class ReverseArray
{
    /// <summary>
    /// <param name="size">Size of the array. <value> Positive integer </value></param>
    /// <param name="input">Array of signed integers</param>
    /// </summary>
    public static String GetInvertedArray(int size, int[] input)
    {
        if(size <= 0){
            throw new ArgumentOutOfRangeException(nameof(size));
        }
        if(input.Length < size){
            throw new ArgumentException();
        }
        
        var invertedArray = input.Reverse().ToArray();
        var output = Array.ConvertAll(invertedArray, IntToString);
        return string.Join(' ', output);
    }

    private static string IntToString(int input)
    {
        return input.ToString();
    }
    
}
