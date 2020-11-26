using System;
using Spectre.Console;

namespace spectre
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AnsiConsole.MarkupLine("[underline red]Hello[/] World!");
            // Create a table
            var table = new Table();

            // Add some columns
            table.AddColumn("Foo");
            table.AddColumn(new TableColumn("Bar").Centered());

            // Add some rows
            table.AddRow("Baz", "[green]Qux[/]");
            table.AddRow(new Markup("[blue]Corgi[/]"), new Panel("Waldo"));

            // Render the table to the console
            AnsiConsole.Render(table);

            var calendar = new Calendar(DateTime.Now.Year, DateTime.Now.Month);
            calendar.Culture = new System.Globalization.CultureInfo("es-MX");
            AnsiConsole.Render(calendar);
            AnsiConsole.Render(
    new FigletText("Hello")
        .LeftAligned()
        .Color(Color.Red));
            // Markup
            AnsiConsole.MarkupLine("Hello :globe_showing_europe_africa:!");

            // Constant
            var hellox = "Hello " + Emoji.Known.GlobeShowingAmericas;
            AnsiConsole.WriteLine(hellox);


        }
    }
}
