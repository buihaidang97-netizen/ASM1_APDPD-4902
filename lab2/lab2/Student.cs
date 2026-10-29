using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
   public class Student
    {

        // định nghĩa thuộc tính : đặc điểm, tính chất của đối tượng trong class
        // thuộc tính thông thường miêu tả qua tính từ và danh từ

        public string FullName { get; set; } = "Bui Hai Dang";
        // get và set: là giá trị hoặc thay đổi giá trị của thuộc tính 
        // public : từ khóa( key word) mô tả phạm vi hoạt dộng vủa thuộc tính
        // public : cho phép thuộc tính được gọi và sử dụng ở bất kỳ đâu trong chương trình

        protected string PhoneNumber { get; set; } = "0987654321";
        // protected : cho phép thuộc tính được gọi và sử dụng trong class và các class kế thừa từ class đó

        private string Monney   { get; set; } = "5000000";
        // private : cho phép thuộc tính được gọi và sử dụng trong class đó
        // định nghĩa phương thức : hành vi, chức năng của đối tượng trong class
        public Student(string email, string adress)
        {
            // constructor : phương thức khởi tạo
            // constructor có tên trùng với tên class
            // constructor không có kiểu dữ liệu trả về
            // constructor được gọi khi khởi tạo đối tượng từ class
            Console.WriteLine("Constructor of class Student is running");
            // email, adress: tham số truyền vào constructor
            Console.WriteLine($"Email: {email}, Adress: {adress}");
        }

        public virtual string Study()// virtual : cho phép phương thức được ghi đè (override) trong class kế thừa
        {
            return "C# - OOP";
        }
        protected string Copy()
        {
            return "ASM Final";
        }

        private string Point()
        {
            return "F";
        }




    }
   
}
