public interface IAssignmentObserver
{
    void OnAssignmentCreated(Assignment assignment);
}
 
public class StudentNotifier : IAssignmentObserver
{
    public void OnAssignmentCreated(Assignment assignment) =>
        Console.WriteLine($"Notify class {assignment.ClassId}: new work '{assignment.Title}'.");
}
 
public class DeadlineReminderScheduler : IAssignmentObserver
{
    public void OnAssignmentCreated(Assignment assignment) =>
        Console.WriteLine($"Reminder scheduled for {assignment.DueDate:dd/MM/yyyy}.");
}
 
public class AssignmentPublisher
{
    private readonly List<IAssignmentObserver> _observers = new List<IAssignmentObserver>();
 
    public void Subscribe(IAssignmentObserver observer) => _observers.Add(observer);
 
    public void Publish(Assignment assignment)
    {
        foreach (IAssignmentObserver observer in _observers)
        {
            observer.OnAssignmentCreated(assignment);
        }
    }
}
