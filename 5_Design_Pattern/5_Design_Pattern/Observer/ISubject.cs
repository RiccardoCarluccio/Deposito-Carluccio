namespace _5_Design_Pattern.Observer;

public interface ISubject
{
    void Register(IObserver observer);
    void Remove(IObserver observer);
    void Notify(string message);
}