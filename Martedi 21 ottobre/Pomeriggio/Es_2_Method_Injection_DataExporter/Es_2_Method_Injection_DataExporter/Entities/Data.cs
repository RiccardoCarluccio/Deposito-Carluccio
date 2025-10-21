namespace Es_2_Method_Injection_DataExporter.Entities;

public class Data
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Strategy { get; set; }

    public override string ToString()
    {
        return $"Title: {Title}, Description: {Description}, Strategy: {Strategy}";
    }
}
