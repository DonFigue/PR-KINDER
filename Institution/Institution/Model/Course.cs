using System.ComponentModel.DataAnnotations;

namespace Institution.Model
{
    public class Course
    {
        [Key]
        public int IdCourse { get; set; }
        public string? CourseName { get; set; }
        public string? Professor { get; set; }

    }
}
