public class StudentValidator
{
    public IReadOnlyList<string> Validate(User student)
    {
        var errors = new List<string>();
        if (string.IsNullOrWhiteSpace(student.StudentCode)) errors.Add("Student code is required.");
        if (!student.Email.Contains('@')) errors.Add("Email is invalid.");
        return errors;
    }
}
 
public class StudentService
{
    private readonly StudentValidator _validator;
    private readonly IStudentRepository _repository;
 
    public StudentService(StudentValidator validator, IStudentRepository repository)
    {
        _validator = validator;
        _repository = repository;
    }
 
    public IReadOnlyList<string> Register(User student)
    {
        var errors = _validator.Validate(student);
        if (errors.Count == 0) _repository.Add(student);
        return errors;
    }
}
