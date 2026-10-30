namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khởi tạo đối tượng thuộc class   
            Student svIT = new Student("svit@example.com", " Ha noi ");
            Student svQTKD = new Student("svqtkd@example.com", " Thai Binh ");
            Student svKTDH = new Student("svktdh@example.com", " Da Nang ");
            // tạo ra 3 object thuộc class Student
            // sử dụng từ khóa new để khởi tạo đối tượng

            ITStudent SE08201 = new ITStudent("nongthiquocthang@gmail.com", " Ha Noi ");
            ITStudent SE08202 = new ITStudent("lethianhquan@gmail.com   ", " Thai Binh ");

            // truy cập và thay đổi giá trị của thuộc tính 
            string myName = svIT.FullName; // lấy ra được giá trị của thuộc tính ( sử dụng object truy cập vào bên trong thuộc tính của class )
            Console.WriteLine("Tên sinh viên IT: " + myName);
            // Console.WriteLine("Tên sinh viên IT: " + svIT.FullName); // error - PhoneNumber là protected nên không thể truy cập từ bên ngoài class
            // Console.WriteLine("Tên sinh viên IT: " + svIT.Monney); // error - Monney là private nên không thể truy cập từ bên ngoài class

            string subjectIT = svIT.Study(); // () : thực thi - chạy phương thức
            Console.WriteLine("Môn học sinh viên IT: " + subjectIT);
            // Console.WriteLine("svIT.Copy(): " + svIT.Copy()); // error - Copy là protected nên không thể truy cập từ bên ngoài class
            // Console.WriteLine("svIT.Point(): " + svIT.Point()); // error - Point là private nên không thể truy cập từ bên ngoài class
            
            PhuongTrinhBac2 ptb2 = new PhuongTrinhBac2(1, -3, 2);
            string result = ptb2.ShowResult();
            Console.WriteLine(result);

            MarthFormula formula = new Rectangle(5, 10);
            double area = formula.CalculateArea();
            double perimeter = formula.CalculatePerimeter();
            Console.WriteLine($"Diện tích hình chữ nhật: {area}");
            Console.WriteLine($"Chu vi hình chữ nhật: {perimeter}");


            Shapes circle = new Circle(5);
            double circleArea = circle.Area();
            double circlePerimeter = circle.Perimeter();
            Console.WriteLine($"Diện tích hình tròn: {circleArea}");
            Console.WriteLine($"Chu vi hình tròn: {circlePerimeter}");

        }



    }
}