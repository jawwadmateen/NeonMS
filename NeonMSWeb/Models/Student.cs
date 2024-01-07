using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeonMSWeb.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
       

        public bool Status { get; set; } = true;
        [Required]
        public int Semester { get; set; }
        [Required]
        public string BatchYear { get; set; }

        [Required]
        public double  CGPA { get; set; }

        [Required]
        public double  SGPA { get; set; }

        public virtual User User { get; set; }

    }  
        
}
