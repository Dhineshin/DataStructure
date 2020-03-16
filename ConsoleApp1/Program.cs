using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Stopwatch timer = new Stopwatch();

        static void Main(string[] args)
        {
            ISort bubble;

            bubble = new bubblesort();
            //bubble = new InsertionSortDhinesh();            
            //bubble = new SelectionSort();
            Console.WriteLine();                       
            
            bubble.Run();
        }
    }
}
