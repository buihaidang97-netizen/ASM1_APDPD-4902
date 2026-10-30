public class ClassWaitingList
{
    private readonly Queue<string> _waitingStudentCodes = new Queue<string>();

    public void Join(string studentCode)
    {
        if (string.IsNullOrWhiteSpace(studentCode))
            throw new ArgumentException("Student code is required.", nameof(studentCode));

        _waitingStudentCodes.Enqueue(studentCode.Trim());
    }

    // FIFO preserves request order when a seat becomes available.
    public bool TryOfferNextSeat(out string? studentCode)
    {
        if (_waitingStudentCodes.TryDequeue(out string? nextStudentCode))
        {
            studentCode = nextStudentCode;
            return true;
        }

        studentCode = null;
        return false;
    }

    public int Count => _waitingStudentCodes.Count;
}
