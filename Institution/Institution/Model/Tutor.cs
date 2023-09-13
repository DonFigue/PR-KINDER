using System.ComponentModel.DataAnnotations;
namespace Institution.Model
{
    public class Tutor
    {
        [Key]
        public int IdTutor { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Ci { get; set; }
        public string? Cellphone { get; set; }
        public DateTime Birthdate { get; set; }
        public int IdProvince { get; set; }
    }
}
