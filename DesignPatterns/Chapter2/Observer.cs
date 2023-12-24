using System;

namespace DesignPatterns.Chapter2;

public class Observer: IObserver, IDisplay
{
    private SubjectData _subjectData;
    public void Update(SubjectData subjectData)
    {
        _subjectData = subjectData;
        // do something 
    }

    public void Display()
    {
        Console.WriteLine(_subjectData);
    }
}