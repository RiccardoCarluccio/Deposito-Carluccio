namespace Es_1_Method_Injection_AlertService.Dependency_Injection;

public interface ISomethingUseful
{
    void Doer(string thing);
}

public class SomethingUseful : ISomethingUseful
{
    public void Doer(string thing)
    {
        Console.WriteLine($"You are doing {thing}");
    }
}
