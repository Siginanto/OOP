using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static (int min, int max) FindMinMax(IEnumerable<int> numbers)
    {
        if (numbers?.Any() != true)
            throw new ArgumentException("Массив не может быть null или пустым", nameof(numbers));
        
        return (numbers.Min(), numbers.Max());
    }

    public static void Main()
    {
        try
        {
            var testData = new List<int> { 5, 2, 9, 1, 7 };
            var (minimum, maximum) = FindMinMax(testData);
            Console.WriteLine($"Min: {minimum}, Max: {maximum}"); // Min: 1, Max: 9
            
            // Тест с одним элементом
            var single = FindMinMax(new[] { 42 });
            Console.WriteLine($"Single: {single}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}