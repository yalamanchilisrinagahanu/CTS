using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore8.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public List<Student> Students { get; set; }
    }
}
