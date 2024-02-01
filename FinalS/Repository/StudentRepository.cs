using MAYAZ203.Models;
using MAYAZ203.Repostory.Contract;
using Microsoft.EntityFrameworkCore;

namespace MAYAZ203.Repostory;
public class StudentRepository : IStudentRepository
{
    private RepositoryContext context;
    public StudentRepository()
    {
        context = new RepositoryContext();
    }
    public void AddStudentToCourse(int courseId, Student student)
    {
        var course = context.Courses.Include(c => c.Students).ToList().Where(c => c.CourseId == courseId).FirstOrDefault();
        course.Students.Add(new Student(){
            StudentName = student.StudentName,
            Major= student.Major,
            GPA = student.GPA,
        
        });
        context.SaveChanges();
    }

    public void DeleteAllStudentsByCourse(Course course)
    {
        var courseToDelete = context.Courses.Include(c => c.Students).ToList().Where(c => c.CourseId == course.CourseId).FirstOrDefault();
        courseToDelete.Students.Clear();
        context.Students.ExecuteDelete();
        context.Students.RemoveRange(courseToDelete.Students);
        context.SaveChanges();
    }
}