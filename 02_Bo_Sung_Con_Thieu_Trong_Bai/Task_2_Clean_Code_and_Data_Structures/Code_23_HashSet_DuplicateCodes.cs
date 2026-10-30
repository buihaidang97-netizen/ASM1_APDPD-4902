HashSet<string> seenStudentCodes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
 
foreach (StudentRow row in csvRows)
{
    bool isNewCode = seenStudentCodes.Add(row.StudentCode);
    if (!isNewCode)
    {
        importReport.AddError(row.LineNumber, "Duplicate student code");
        continue;
    }
    studentRepository.Add(row.ToUser());
}
