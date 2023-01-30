namespace intersysTasks.tasks;

using System;
using System.Linq;

/// <summary>
/// Write a program that takes an array of size N as input and gives the output as an array in the reverse order.
///  The format of the input is as follow:
/// N
/// a1 a2 a3 a4 a5 … an
/// 'N' is the size of the array and a1, a2, a3, … an, are its elements.
/// Your program should give output (on the same line and separated by a space) as follows:
/// an an-1 an-2 … a1
/// </summary>
public static class ReverseArray
{
    public static Array ReverseArr(int size, int[] input){
        if(size <= 0){
            throw new ArgumentOutOfRangeException(nameof(size));
        }
        if(input.Length < size){
            throw new ArgumentException("input.Length < size");
        }
        return input.Reverse().ToArray();    
    }
}
