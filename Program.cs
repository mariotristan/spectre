using System;
using Spectre.Console;

namespace spectre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	    AnsiConsole.Markup("[underline red]Hello[/] World!");
        }
    }
}
