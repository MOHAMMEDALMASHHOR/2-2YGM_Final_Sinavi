using MAYAZ203.Models;
using MAYAZ203.Repostory.Contract;

namespace MAYAZ203.Repostory;
public class CourseRepository : ICourseRepository
{
    private RepositoryContext context;
    public CourseRepository()
    {
        context = new RepositoryContext();
    }
    public Course CreateCourseWithStudent(Course course)
    {
        context.Courses.Add(course);
        context.SaveChanges();
        return course;
    }
}