namespace Employee_.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

        public class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public DateOnly DOB { get; set; }

            public float Salary { get; set; }

            // Foreign key to Department
            [ForeignKey("Department_")]
            public int? Department_id { get; set; }
            public Department? Department_ { get; set; }

            // Foreign key to HR
            [ForeignKey("Hr_")]
            public int? Hr_id { get; set; }
            public Hr? Hr_ { get; set; }

            // Self-referencing foreign key to Senior
            [ForeignKey("Senior")]
            public int? Senior_id { get; set; }
            public Employee? Senior { get; set; }

            public List<Skill> Skills { get; set; } = new List<Skill>();
        }
    }

