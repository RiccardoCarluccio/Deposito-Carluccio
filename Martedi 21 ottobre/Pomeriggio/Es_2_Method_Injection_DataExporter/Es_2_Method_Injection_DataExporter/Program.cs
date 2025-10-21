using Es_2_Method_Injection_DataExporter.Entities;
using Es_2_Method_Injection_DataExporter.Method_Injection;
using Es_2_Method_Injection_DataExporter.Services;

IExportFormatter formatter = new ExportFormatter();
var service = new DataExporter();

Data data = new Data
{
    Title = "Company Report",
    Description = "Positive monthly tendency",
    Strategy = "JSON"
};

service.Export(data, formatter);