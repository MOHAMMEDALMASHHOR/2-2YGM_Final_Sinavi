using MAYAZ203.Models;

namespace MAYAZ203.Repostory.Contract;
public interface ICourseRepository{
    Course CreateCourseWithStudent(Course course);
}