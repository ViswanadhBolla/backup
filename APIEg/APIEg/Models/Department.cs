using System;
using System.Collections.Generic;

namespace APIEg.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Did { get; set; }
        public string? Dname { get; set; }
        public string? Place { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
