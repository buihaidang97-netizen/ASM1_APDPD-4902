using System;
using System.Collections.Generic;
 
namespace ASM1_UnitTest
{
    // Data held by the student in this in-memory prototype.
    public class Student
    {
        public string StudentId { get; set; } = "S001";
        public string ProgramCode { get; set; } = "IT";
        public bool IsActive { get; set; } = true;
        public int CurrentCredits { get; set; } = 9;
        public int MaxCredits { get; set; } = 18;
        public HashSet<string> CompletedCourses { get; set; } = new HashSet<string>();
        public HashSet<string> EnrolledCourses { get; set; } = new HashSet<string>();
    }
 
    public class Course
    {
        public string CourseCode { get; set; } = "CS101";
        public string ProgramCode { get; set; } = "IT";
        public int Capacity { get; set; } = 30;
        public int EnrolledCount { get; set; } = 10;
        public int Credits { get; set; } = 3;
        public string? PrerequisiteCode { get; set; } = null;
    }
 
    public enum EnrollmentResult
    {
        Success, InactiveStudent, ProgrammeMismatch,
        MissingPrerequisite, CourseFull,
        AlreadyEnrolled, CreditLimitExceeded
    }
 
    public class EnrollmentService
    {
        public EnrollmentResult Enroll(Student student, Course course)
        {
            if (!student.IsActive)
                return EnrollmentResult.InactiveStudent;
            if (student.ProgramCode != course.ProgramCode)
                return EnrollmentResult.ProgrammeMismatch;
            if (course.PrerequisiteCode != null &&
                !student.CompletedCourses.Contains(course.PrerequisiteCode))
                return EnrollmentResult.MissingPrerequisite;
            if (course.EnrolledCount >= course.Capacity)
                return EnrollmentResult.CourseFull;
            if (student.EnrolledCourses.Contains(course.CourseCode))
                return EnrollmentResult.AlreadyEnrolled;
            if (student.CurrentCredits + course.Credits > student.MaxCredits)
                return EnrollmentResult.CreditLimitExceeded;
 
            student.EnrolledCourses.Add(course.CourseCode);
            student.CurrentCredits += course.Credits;
            course.EnrolledCount++;
            return EnrollmentResult.Success;
        }
    }
}
