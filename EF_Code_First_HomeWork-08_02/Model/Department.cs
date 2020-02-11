using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Code_First_HomeWork_08_02.Model
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [MaxLength(30)]
        public string DepartmentName { get; set; }

        public int ManagerId { get; set; }


        public Location Location { get; set; }

        public IEnumerable<JobHistory> JobHistories { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
