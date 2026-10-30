public class ClassController : Controller
{
    [HttpPost]
    public IActionResult AddStudent(long classId, string studentCode)
    {
        var studentRows = File.ReadAllLines("users.csv").Skip(1).Select(line => line.Split(','));
        var student = studentRows.FirstOrDefault(row => row.Length > 14 && row[14] == studentCode);
        if (student == null) return NotFound("student not found");

        var classRows = File.ReadAllLines("classes.csv").Skip(1).Select(line => line.Split(','));
        var classRow = classRows.FirstOrDefault(row => row.Length > 3 && long.Parse(row[0]) == classId);
        if (classRow == null) return NotFound("class not found");
        if (student[1] != classRow[3]) return BadRequest("wrong major");

        var enrollmentRows = File.ReadAllLines("enrollments.csv").Skip(1).Select(line => line.Split(','));
        bool duplicate = enrollmentRows.Any(row => row.Length > 2 &&
            row[1] == student[0] && row[2] == classId.ToString());
        if (duplicate) return BadRequest("already enrolled");

        int enrolledCount = enrollmentRows.Count(row => row.Length > 2 && row[2] == classId.ToString());
        if (enrolledCount >= 30) return BadRequest("class full");

        long nextId = enrollmentRows.Select(row => long.Parse(row[0])).DefaultIfEmpty(0).Max() + 1;
        File.AppendAllText("enrollments.csv", $"{nextId},{student[0]},{classId},{DateTime.UtcNow:O}\n");
        return Ok();
    }
}
