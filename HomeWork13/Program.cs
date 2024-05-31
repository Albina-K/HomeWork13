using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork1;

class Program
{
    public static List<string> list = new List<string>();
    static void Main(string[] args)
    {
        string text = File.ReadAllText(@"C:\Users\Альбина\Desktop\HW13.txt");

        var watchOne = Stopwatch.StartNew();

        list.Add(text);

        Console.WriteLine($"Вставка в List:{watchOne.Elapsed.TotalMilliseconds} мс");
    }
        
}
