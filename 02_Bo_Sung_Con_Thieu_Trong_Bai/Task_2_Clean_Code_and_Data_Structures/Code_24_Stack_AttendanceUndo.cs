public class AttendanceEditor
{
    private readonly Stack<AttendanceChange> _history = new Stack<AttendanceChange>();
 
    public void Mark(Attendance attendance, AttendanceStatus newStatus)
    {
        _history.Push(new AttendanceChange(attendance, attendance.Status));
        attendance.Status = newStatus;
    }
 
    public bool UndoLastChange()
    {
        if (!_history.TryPop(out AttendanceChange? lastChange))
            return false;
        lastChange.Attendance.Status = lastChange.PreviousStatus;
        return true;
    }
}
 
public record AttendanceChange(Attendance Attendance, AttendanceStatus PreviousStatus);
