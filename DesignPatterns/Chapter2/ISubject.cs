namespace DesignPatterns.Chapter2;

public interface ISubject
{
    public void AddObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void UpdateSubjectData(SubjectData subjectData);
    public void Notify();
}