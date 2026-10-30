// Before: a linear search for every row, O(n) each time, O(n*m) overall
foreach (var row in enrollmentRows)
{
    var s = students.FirstOrDefault(x => x.StudentCode == row.StudentCode);
}
 
// After: build the index once, then O(1) per lookup
Dictionary<string, User> studentsByCode = students
    .ToDictionary(student => student.StudentCode);
 
foreach (EnrollmentRow row in enrollmentRows)
{
    if (!studentsByCode.TryGetValue(row.StudentCode, out User? student))
    {
        importReport.AddError(row.LineNumber, "Unknown student code");
        continue;
    }
    // ... enrol the student
}
