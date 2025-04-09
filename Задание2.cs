using System;
using System.Collections.Generic;

public class Program
{
    public static int CountUniqueChars(string str)
    {
        HashSet<char> uniqueChars = new HashSet<char>();
        
        foreach (char c in str)
        {
            uniqueChars.Add(c);
        }
        
        return uniqueChars.Count;
    }

    public static void Main()
    {
        Console.WriteLine(CountUniqueChars("hello"));   
        Console.WriteLine(CountUniqueChars("apple"));   
        Console.WriteLine(CountUniqueChars("banana"));  
        Console.WriteLine(CountUniqueChars(""));        
        Console.WriteLine(CountUniqueChars("aabbbcc")); 
    }
}