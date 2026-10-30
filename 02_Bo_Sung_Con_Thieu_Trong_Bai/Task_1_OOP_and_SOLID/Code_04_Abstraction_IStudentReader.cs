public interface IStudentReader
{
    User? GetByStudentCode(string studentCode);
}
 
public class StudentService
{
    private readonly IStudentReader _repository;
 
    public StudentService(IStudentReader repository)
    {
        _repository = repository;
    }
 
    public bool Exists(string studentCode) =>
        _repository.GetByStudentCode(studentCode) != null;
}
