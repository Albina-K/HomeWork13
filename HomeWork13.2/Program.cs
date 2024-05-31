using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork2;

class Program
{
    public static LinkedList<string> linkedList = new LinkedList<string>();
    static void Main(string[] args)
    {
        string text = File.ReadAllText(@"C:\Users\Альбина\Desktop\HW13.txt");

        var watchOne = Stopwatch.StartNew();

        linkedList.AddFirst(text);

        Console.WriteLine($"Вставка в LinkedList:{watchOne.Elapsed.TotalMilliseconds} мс");

    }

}
