using MAYAZ203.Models;

namespace MAYAZ203.Repostory.Contract;
public interface IStudentRepository
{
    void DeleteAllStudentsByCourse(Course course);
    void AddStudentToCourse(int courseId, Student student);
}