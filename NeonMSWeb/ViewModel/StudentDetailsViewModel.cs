using NeonMSWeb.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NeonMSWeb.ViewModel
{
    public class StudentDetailsViewModel
    {
        public int StudentID { get; set; }

        
        public int UserID { get; set; }


        public bool Status { get; set; } = true;
       
        public int Semester { get; set; }
        
        public string BatchYear { get; set; }

        
        public double CGPA { get; set; }

        
        public double SGPA { get; set; }

        public virtual User User { get; set; }

        
        public int UserId { get; set; }
        
        public string UserName { get; set; }
        
        public string Password { get; set; }

        // Personal Information

       
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public string DateOfBirth { get; set; }
        public string CreatedDateTime { get; set; } 

        // Address Information
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
       
        public string ZipCode { get; set; }

        // University Information
        
        public string DepartmentID { get; set; }



        public virtual Student Student { get; set; }
    }
}
