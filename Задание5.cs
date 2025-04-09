using System;

public class Program
{
    public static string ConvertTo12HourFormat(int hours, int minutes)
    {
        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
        {
            throw new ArgumentException("Некорректное время. Часы должны быть 0-23, минуты 0-59");
        }

        string period = hours < 12 ? "AM" : "PM";

        int twelveHour = hours switch
        {
            0 => 12,  
            12 => 12,  
            _ => hours % 12
        };

        // Форматирование строки результата
        return $"{twelveHour}:{minutes:D2} {period}";
    }

    public static void Main()
    {
        try
        {
            Console.WriteLine(ConvertTo12HourFormat(14, 30)); 
            Console.WriteLine(ConvertTo12HourFormat(0, 45));  
            Console.WriteLine(ConvertTo12HourFormat(12, 0));  
            Console.WriteLine(ConvertTo12HourFormat(23, 15)); 
            Console.WriteLine(ConvertTo12HourFormat(8, 5));   
            
            // Тест с некорректным временем
            // Console.WriteLine(ConvertTo12HourFormat(25, 70));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}