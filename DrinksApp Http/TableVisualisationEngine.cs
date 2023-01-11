using ConsoleTableExt;
using System.Diagnostics.CodeAnalysis;

namespace DrinksApp_Http
{
    internal class TableVisualisationEngine
    {
        public static void DisplayTable<T>(List<T> tableData, [AllowNull] string tableName) where T: class 
        {
            Console.Clear();

            if (tableName == null) tableName = "";

            Console.WriteLine("\n");

            ConsoleTableBuilder
                .From(tableData)
                .WithColumn(tableName)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine(TableAligntment.Center);

            Console.WriteLine("\n");
        }
    }
}
