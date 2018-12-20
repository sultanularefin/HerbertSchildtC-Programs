﻿/* An exception can be generated by one
method and caught by another. */
using System;
class ExcTest
{
    // Generate an exception.
    public static void GenException()
    {
        int[] nums = new int[4];
        Console.WriteLine("Before exception is generated.");
        // Generate an index out-of-bounds exception.
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i;
            Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
        }

        Console.WriteLine("this won't be displayed");
    }
}
class ExcDemo2
{
    static void Main()
    {
        try
        {
            ExcTest.GenException();
        }
        catch (IndexOutOfRangeException)
        {
            // Catch the exception.
            Console.WriteLine("Index out-of-bounds!");
        }
        Console.WriteLine("After catch block.");
    }
}