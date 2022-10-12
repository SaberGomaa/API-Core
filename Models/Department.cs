using MessagePack;
using Newtonsoft.Json;

namespace API_Core.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ICollection<Employee> employees { get; set; }
    }
}
