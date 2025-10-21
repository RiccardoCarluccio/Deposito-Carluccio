using Es_2_Method_Injection_DataExporter.Entities;

namespace Es_2_Method_Injection_DataExporter.Method_Injection;

public interface IExportFormatter
{
    void Format(Data data, string strategy);
}
public class ExportFormatter : IExportFormatter
{
    public void Format(Data data, string strategy)
    {
        Console.WriteLine($"'{data}'\n" +
            $"will be formatted in {strategy}");
    }
}
