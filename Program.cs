using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Task13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            var strings = new List<string>();
            string text = File.ReadAllText("D:\\Downloads\\Text1.txt");
            strings.Add(text);
            Console.WriteLine($"List Time Elapsed: {stopWatch.Elapsed.TotalMilliseconds} ms");//замер для List 

            stopWatch = Stopwatch.StartNew();
            LinkedList<string> LinkedList = new LinkedList<string>();
            text = File.ReadAllText("D:\\Downloads\\Text1.txt");
            LinkedList.AddFirst(text);
            Console.WriteLine($"LinkedList Time Elapsed: {stopWatch.Elapsed.TotalMilliseconds} ms");//замер для  LinkedList. Оказался быстрее
        }
    }
}