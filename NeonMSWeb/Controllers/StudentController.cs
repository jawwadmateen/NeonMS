using Microsoft.AspNetCore.Mvc;
using NeonMSWeb.Data;
using NeonMSWeb.Models;
using NeonMSWeb.ViewModel;
using System.Linq;
using System.Security.Cryptography;

namespace NeonMSWeb.Controllers
{
    [Route("Student")]
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext db1;
        public StudentController(ApplicationDBContext db)
        {
            db1 = db;
        }
        [HttpGet("GetStudentDetailsById/{Student_id}")]
        public IActionResult GetStudentDetailsByID(int Student_id)
        {
            
            var  GetAllStudents= db1.Students.FirstOrDefault(a=>a.StudentID== Student_id);
            int user_id = GetAllStudents.UserID;
            var GetAllUsers = db1.Users.FirstOrDefault(sw => sw.UserId == user_id);
            StudentDetailsViewModel s1= new StudentDetailsViewModel();
            s1.StudentID = GetAllStudents.StudentID;
            s1.BatchYear = GetAllStudents.BatchYear;
            s1.Status = GetAllStudents.Status;
            s1.CGPA= GetAllStudents.CGPA;   
            s1.SGPA= GetAllStudents.SGPA;   
            s1.Semester= GetAllStudents.Semester;
            s1.UserId = GetAllUsers.UserId;
            s1.Address = GetAllUsers.Address;
            s1.City = GetAllUsers.City;
            s1.UserName= GetAllUsers.UserName;  
            s1.CreatedDateTime = Convert.ToString(GetAllUsers.CreatedDateTime);
            s1.DateOfBirth = Convert.ToString(GetAllUsers.DateOfBirth);
            s1.DepartmentID = GetAllUsers.DepartmentID;
            s1.Email = GetAllUsers.Email;
            s1.FirstName = GetAllUsers.FirstName;
            s1.LastName = GetAllUsers.LastName;
            s1.PhoneNumber = GetAllUsers.PhoneNumber;
            s1.State = GetAllUsers.State;
            s1.ZipCode = GetAllUsers.ZipCode;
            return View(s1);
        }
    }
}
