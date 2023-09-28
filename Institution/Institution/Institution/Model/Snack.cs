using System.ComponentModel.DataAnnotations;
namespace Institution.Model
{
    public class Snack
    {
        [Key]
        public int IdSnack { get; set; }
        public string SnackName { get; set; }
        public string Description { get; set; }
    }
}
