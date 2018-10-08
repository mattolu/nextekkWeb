using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeWeb
{ 
    public class Employee
    {
        public int EmployeeId { get; set; }
            
        public string FirstName { get; set; }
        [StringLength(50)]   
        public string LastName { get; set; }
         [StringLength(75)]
        public string DateOfBirth{ get; set;}
        public string Sex{ get; set; }
        public string MaritalStatus{ get; set; }
        public string Password { get; set; }
        public string ConfirmPassword{ get; set; }
        public int NumberOfChildren{ get; set; } 
    }
}
