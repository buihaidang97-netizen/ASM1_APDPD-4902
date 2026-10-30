using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class ITStudent : Student
    {
        public ITStudent(string email, string adress) : base(email, adress)
        {
            // tính đa hình của lập trình hướng đối tượng (OOP) : kế thừa (inheritance)
            Console.WriteLine("Constructor of class ITStudent is running");
            Console.WriteLine($"ITStudent - Email: {email}, Adress: {adress}");
        }
        public override string Study() 
        {
            // thể hiện tính đa hình của lập trình hướng đối tượng (OOP) : ghi đè (override)
            return "APDP - 4902";
        }
        public string GetSubject()
        {
            //return Study(); // method of child class ITStudent is called
            return base.Study(); // method of parent class Student is called( sừ dụng từ khóa base để gọi phương thức của class cha)
        }
    }
}
