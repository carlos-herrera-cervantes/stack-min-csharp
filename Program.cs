using System;
using StackMinConsoleApp.Models;

namespace StackMinConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new StackWithMin();

            Console.WriteLine($"The minimum value is: {stack.GetMinimum()}");
        }
    }
}