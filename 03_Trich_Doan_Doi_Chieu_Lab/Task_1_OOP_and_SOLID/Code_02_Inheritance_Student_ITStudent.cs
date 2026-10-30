public class Student
{
    public virtual string Study()   // virtual: may be overridden
    {
        return "C# - OOP";
    }
}
 
public class ITStudent : Student
{
    public ITStudent(string email, string adress) : base(email, adress) { }
 
    public override string Study()
    {
        return "APDP - 4902";
    }
}
