using Es_2_Method_Injection_DataExporter.Entities;
using Es_2_Method_Injection_DataExporter.Method_Injection;

namespace Es_2_Method_Injection_DataExporter.Services;

public class DataExporter
{
    public void Export(Data data, IExportFormatter formatter)
    {
        formatter.Format(data, data.Strategy);
    }
}
