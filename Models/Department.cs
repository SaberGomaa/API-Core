using MessagePack;

namespace API_Core.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Employee> employees { get; set; }
    }
}
