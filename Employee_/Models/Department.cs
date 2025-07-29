using System.ComponentModel.DataAnnotations;

namespace Employee_.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

    }
}
