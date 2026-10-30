using Xunit;
 
namespace ASM1_UnitTest
{
    public class EnrollmentServiceTests
    {
        private Student CreateStudent()
        {
            return new Student
            {
                StudentId = "S001", ProgramCode = "IT",
                IsActive = true, CurrentCredits = 9, MaxCredits = 18
            };
        }
 
        private Course CreateCourse()
        {
            return new Course
            {
                CourseCode = "CS101", ProgramCode = "IT",
                Capacity = 30, EnrolledCount = 10, Credits = 3
            };
        }
 
        [Fact]
        public void Test01_ValidEnrollment_ReturnsSuccess()
        {
            // Arrange
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            // Act
            var result = service.Enroll(student, course);
            // Assert
            Assert.Equal(EnrollmentResult.Success, result);
            Assert.Contains("CS101", student.EnrolledCourses);
            Assert.Equal(12, student.CurrentCredits);
            Assert.Equal(11, course.EnrolledCount);
        }
 
        [Fact]
        public void Test02_InactiveStudent_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            student.IsActive = false;
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.InactiveStudent, result);
        }
 
        [Fact]
        public void Test03_ProgrammeMismatch_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            student.ProgramCode = "BUSINESS";
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.ProgrammeMismatch, result);
        }
 
        [Fact]
        public void Test04_MissingPrerequisite_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            course.PrerequisiteCode = "CS100";
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.MissingPrerequisite, result);
        }
 
        [Fact]
        public void Test05_FullCourse_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            course.EnrolledCount = 30;
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.CourseFull, result);
        }
 
        [Fact]
        public void Test06_DuplicateEnrollment_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            student.EnrolledCourses.Add("CS101");
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.AlreadyEnrolled, result);
        }
 
        [Fact]
        public void Test07_CreditLimitExceeded_IsRejected()
        {
            var service = new EnrollmentService();
            var student = CreateStudent();
            var course = CreateCourse();
            student.CurrentCredits = 17;
            var result = service.Enroll(student, course);
            Assert.Equal(EnrollmentResult.CreditLimitExceeded, result);
        }
    }
}
