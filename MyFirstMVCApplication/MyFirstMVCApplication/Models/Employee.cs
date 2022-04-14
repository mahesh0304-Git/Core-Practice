using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyFirstMVCApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        [Required ( ErrorMessage = "Employee Name cannot be blank!")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Employee ID is Mandatory!")]
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Emp ID")]
        public string EmpID { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string Location { get; set; }
        
    }
}
