public interface IStudentReader
{
    User? GetByStudentCode(string studentCode);
}

public interface IStudentWriter
{
    void Add(User student);
    void Update(User student);
}

public interface IStudentRepository : IStudentReader, IStudentWriter { }

public class StudentDashboardService
{
    private readonly IStudentReader _reader; // cannot write by design
    public StudentDashboardService(IStudentReader reader) => _reader = reader;

    public User? FindStudent(string studentCode) =>
        _reader.GetByStudentCode(studentCode);
}
