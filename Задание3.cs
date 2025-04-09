using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<int> FilterGreaterThan(List<int> arr, int threshold) 
        => arr.Where(x => x > threshold).ToList();

    public static void Main()
    {
        var numbers = new List<int> {1, 5, 8, 3, 10};
        var filtered = FilterGreaterThan(numbers, 5);
        
        Console.WriteLine(string.Join(", ", filtered));
        
        // Дополнительные тесты
        Console.WriteLine(string.Join(", ", FilterGreaterThan(new List<int>(), 5))); 
        Console.WriteLine(string.Join(", ", FilterGreaterThan(new List<int> {1, 2, 3}, 5))); 
        Console.WriteLine(string.Join(", ", FilterGreaterThan(new List<int> {10, 20, 30}, 5))); 
    }
}