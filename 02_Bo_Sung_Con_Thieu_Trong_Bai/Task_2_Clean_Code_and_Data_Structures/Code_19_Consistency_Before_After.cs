// Inconsistent: mixed casing, different error styles
public bool add_student(User S) { if(S==null) return false; ... }
public void RemoveStudent(User student) { if (student == null) throw new Exception(); }
 
// Consistent: same casing, same guard, same exception type
public void AddStudent(User student)
{
    ArgumentNullException.ThrowIfNull(student);
    // ...
}
 
public void RemoveStudent(User student)
{
    ArgumentNullException.ThrowIfNull(student);
    // ...
}
