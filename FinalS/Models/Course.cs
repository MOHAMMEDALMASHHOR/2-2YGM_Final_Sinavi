namespace MAYAZ203.Models;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string Instructor { get; set; }
    public int CreditHour { get; set; }
    public ICollection<Student> Students { get; set; }
    public Course()
    {
        Students= new List<Student>();
    }
}