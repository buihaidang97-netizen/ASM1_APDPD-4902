public enum EnrollmentFlowResult
{
    Success, StudentNotFound, ClassNotFound, ProgrammeMismatch, AlreadyEnrolled, CourseFull
}

public interface IStudentReader { User? GetByStudentCode(string studentCode); }

public interface IClassRoomRepository
{
    ClassRoom? GetById(long classId);
    EnrollmentFlowResult TryEnrollAtomically(ClassRoom classRoom, User student);
}

public class ClassController : Controller
{
    private readonly EnrollmentService _service;
    public ClassController(EnrollmentService service) => _service = service;

    [HttpPost, Authorize(Policy = "AdminOnly")]
    public IActionResult AddStudent(long classId, string studentCode)
    {
        var result = _service.AddStudentToClass(studentCode, classId);
        if (result == EnrollmentFlowResult.Success) return Ok();
        if (result is EnrollmentFlowResult.StudentNotFound or EnrollmentFlowResult.ClassNotFound)
            return NotFound();
        return BadRequest(result.ToString());
    }
}

public class EnrollmentService
{
    private readonly IStudentReader _students;
    private readonly IClassRoomRepository _classes;

    public EnrollmentService(IStudentReader students, IClassRoomRepository classes)
    {
        _students = students;
        _classes = classes;
    }

    public EnrollmentFlowResult AddStudentToClass(string code, long classId)
    {
        var student = _students.GetByStudentCode(code);
        if (student is null) return EnrollmentFlowResult.StudentNotFound;
        var classRoom = _classes.GetById(classId);
        if (classRoom is null) return EnrollmentFlowResult.ClassNotFound;
        if (student.MajorId != classRoom.MajorId) return EnrollmentFlowResult.ProgrammeMismatch;

        // Repository checks duplicates/capacity and commits atomically.
        return _classes.TryEnrollAtomically(classRoom, student);
    }
}
