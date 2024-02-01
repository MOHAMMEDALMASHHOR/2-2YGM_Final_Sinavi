using MAYAZ203.Models;
using MAYAZ203.Repostory;

CourseRepository courseRepository = new CourseRepository();
Course course = new Course
{
    CourseName = "Nesne Yonelimli Programlama",
    Instructor = "Zafer COMERT",
    CreditHour = 3,
    Students = new List<Student>(){
        new Student{
            StudentId=101,
            StudentName="Ahemt",
            Major="Bilgisayar Muhendisligi",
            GPA=3.5},
        new Student{
            StudentId=102,
            StudentName="Ayse",
            Major="Elektrik Muhendisligi",
            GPA=3.2},
        new Student{
            StudentId=103,
            StudentName="Mehmet",
            Major="Matamatik",
            GPA=3.8},
        new Student{
            StudentId=104,
            StudentName="Fatma",
            Major="Fizik",
            GPA=3.4},
        new Student{
            StudentId=105,
            StudentName="Mehmet",
            Major="Kimya",
            GPA=3.6},
}
};
// courseRepository.CreateCourseWithStudent(course);
var student = new Student(){
    StudentId=106,
    StudentName="Ali",
    Major="Bilgisayar Muhendisligi",
    GPA=3.5
};
var studentRepository = new StudentRepository();
studentRepository.AddStudentToCourse(1,student);
var context=new RepositoryContext();
studentRepository.DeleteAllStudentsByCourse(context.Courses.Where(c => c.CourseId==1).SingleOrDefault()); 
