using ConsoleTableExt;

namespace DrinksApp_Http
{
    internal class TableVisualisationEngine
    {
        internal void DisplayDataInTable(List<object> dataList, string dataType)
        {
            ConsoleTableBuilder
                .From(dataList)
                .WithColumn(dataType)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine();
        }
        internal void DisplayDataInTable(List<List<object>> dataList, string dataType)
        {
            ConsoleTableBuilder
                .From(dataList)
                .WithColumn("Number", dataType)
                .WithFormat(ConsoleTableBuilderFormat.Alternative)
                .ExportAndWriteLine();
        }
    }
}
