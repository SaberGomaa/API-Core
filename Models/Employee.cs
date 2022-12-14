using System.ComponentModel.DataAnnotations.Schema;

namespace API_Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int Age { get; set; }
        public string Address { get; set; }

        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }
}
