// Before: one method parses, validates and decides, with magic numbers
public bool Check(string line)
{
    var p = line.Split(',');
    return p.Length == 4 && p[2].Contains("@") && int.Parse(p[3]) <= 18;
}
 
// After: each step is a named method; the limit is a constant
private const int MaxCreditsPerTerm = 18;
 
public bool IsValidStudentRow(string csvLine)
{
    string[] fields = ParseFields(csvLine);
    return HasExpectedColumnCount(fields)
        && IsValidEmail(fields[2])
        && int.Parse(fields[3]) <= MaxCreditsPerTerm;
}
