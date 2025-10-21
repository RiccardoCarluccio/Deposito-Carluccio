using Es_1_Method_Injection_AlertService.Dependency_Injection;
using Es_1_Method_Injection_AlertService.Method_Injection;
using Es_1_Method_Injection_AlertService.Service;

class Program
{
    static void Main()
    {
        INotifier notifier = new SmsNotifier();                     //Interface for the method injection
        ISomethingUseful something = new SomethingUseful();         //interface for the dependency injection
        var service = new AlertService(something);

        service.SendNotification("John", notifier);
        service.Somethinger("something");
    }
}