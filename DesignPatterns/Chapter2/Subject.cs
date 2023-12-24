using System.Collections.Generic;

namespace DesignPatterns.Chapter2;

public class Subject: ISubject
{
    private List<IObserver> _observers = new();
    private SubjectData _subjectData;
    
    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void UpdateSubjectData(SubjectData subjectData)
    {
        _subjectData = subjectData;
        Notify();
    }

    public void Notify()
    {
        foreach(var observer in _observers)
            observer.Update(_subjectData);
    }
}