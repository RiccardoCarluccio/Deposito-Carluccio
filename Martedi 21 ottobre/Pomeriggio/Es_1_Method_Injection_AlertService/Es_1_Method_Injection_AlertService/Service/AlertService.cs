using Es_1_Method_Injection_AlertService.Dependency_Injection;
using Es_1_Method_Injection_AlertService.Method_Injection;

namespace Es_1_Method_Injection_AlertService.Service;

public class AlertService
{
    private readonly ISomethingUseful _something;

    public AlertService(ISomethingUseful something)
    {
        _something = something;
    }

    public void SendNotification(string user, INotifier notifier)
    {
        notifier.Notify($"Alert {user}!");
    }

    public void Somethinger(string thing)
    {
        _something.Doer(thing);
    }
}
