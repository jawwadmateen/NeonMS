using System.ComponentModel.DataAnnotations;

namespace NeonMSWeb.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        // Personal Information

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDateTime { get; set; }= DateTime.Now;

        // Address Information
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }

        // University Information
        [Required]
        public string DepartmentID { get; set; }

        

        public virtual Student Student { get; set; }

    }
}
